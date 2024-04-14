using Application.DTO.Error;
using Application.DTO.Pagination;
using Application.DTO.Response;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;

namespace Application.UseCase.Services
{
    public class ApplicantQueryService : IApplicantQueryService
    {
        private IApplicantQuery _query;
        private readonly IMapper _mapper;
        private List<ApplicantResponse> list;

        public ApplicantQueryService(IApplicantQuery query, IMapper mapper)
        {
            _query = query;
            _mapper = mapper;
            list = new();
        }

        public async Task<Paged<ApplicantResponse>> GetAllPaged(int pageNumber, int pageSize)
        {
            try
            {
                if (pageNumber <= 0 || pageSize <= 0)
                {
                    throw new BadRequestException("Ingrese valores mayores que cero (0) para pageNumber y pageSize");
                }
                Parameters parameters = new Parameters(pageNumber, pageSize);
                Paged<Applicant> applicants = await _query.RecoveryAll(parameters);
                applicants.Data.ForEach(e =>
                {
                    var applicantResponse = _mapper.Map<ApplicantResponse>(e);
                    applicantResponse.Ubication = new UbicationResponse
                    {
                        Province = e.CityObject.ProvinceObject.Name,
                        City = e.CityObject.Name
                    };
                    list.Add(applicantResponse);
                });

                return new Paged<ApplicantResponse>(list, applicants.MetaData.TotalCount, parameters.PageNumber, parameters.PageSize);
            }
            catch (Exception e)
            {
                if (e is HTTPError)
                {
                    throw;
                }
                throw new InternalServerErrorException(e.Message);
            }
        }

        public async Task<ApplicantResponse> GetById(string id)
        {
            try
            {
                Guid guid;
                if (!Guid.TryParse(id, out guid))
                {
                    throw new BadRequestException("El ID debe ser de tipo GUID.");
                }

                var entity = await _query.RecoveryById(guid);
               
                var response = _mapper.Map<ApplicantResponse>(entity);
                response.Ubication = new UbicationResponse
                {
                    Province = entity.CityObject.ProvinceObject.Name,
                    City = entity.CityObject.Name
                };
                return response;
            }
            catch (Exception e)
            {
                if (e is HTTPError)
                {
                    throw;
                }
                throw new InternalServerErrorException(e.Message);
            }
        }
    }
}
