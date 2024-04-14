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
                Parameters parameters = new Parameters(pageNumber, pageSize);
                Paged<Applicant> applicants = await _query.RecoveryAll(parameters);
                applicants.Data.ForEach(e => list.Add(_mapper.Map<ApplicantResponse>(e)));

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
                if (Guid.TryParse(id, out guid))
                {
                    throw new BadRequestException("El ID debe ser de tipo GUID.");
                }

                var entity = await _query.RecoveryById(guid);
                if (entity == null)
                {
                    throw new NotFoundException("El registro con el ID " + id + " no fue encontrado.");
                }
                return _mapper.Map<ApplicantResponse>(entity);
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
