using Application.DTO.Error;
using Application.DTO.Pagination;
using Application.DTO.Response;
using Application.Interfaces;
using AutoMapper;
using Azure.Core;
using Domain.Entities;

namespace Application.UseCase.Services
{
    public class CompanyQueryService : ICompanyQueryService
    {
        private readonly ICompanyQuery _query;
        private readonly IMapper _mapper;
        private List<CompanyMinimalResponse> list;

        public CompanyQueryService(ICompanyQuery query, IMapper mapper)
        {
            _query = query;
            _mapper = mapper;
            list = new();
        }

        public async Task<Paged<CompanyMinimalResponse>> GetCompanyByFilter(int pageNumber, int pageSize, string? name)
        {
            try
            {
                if (pageNumber <= 0 || pageSize <= 0)
                {
                    throw new BadRequestException("Ingrese valores mayores que cero (0) para pageNumber y pageSize");
                }
                Parameters parameters = new Parameters(pageNumber, pageSize);
                Paged<Company> companies = await _query.RecoveryAll(parameters, name);
                companies.Data.ForEach(e =>
                {
                    var companyResponse = _mapper.Map<CompanyMinimalResponse>(e);
                    companyResponse.Ubication = new UbicationResponse
                    {
                        Province = e.CityObject.ProvinceObject.Name,
                        City = e.CityObject.Name
                    };
                    list.Add(companyResponse);
                });

                return new Paged<CompanyMinimalResponse>(list, companies.MetaData.TotalCount, parameters.PageNumber, parameters.PageSize);
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

        public async Task<CompanyGetResponse> GetByCompanyId(Guid companyId)
        {
            try
            {
                var company = await _query.RecoveryByCompanyId(companyId);

                var response = _mapper.Map<CompanyGetResponse>(company);
                response.Ubication = new UbicationResponse
                {
                    Province = company.CityObject.ProvinceObject.Name,
                    City = company.CityObject.Name
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


        public async Task<CompanyResponse> GetById(string id)
        {
            try
            {
                Guid guid;
                if (!Guid.TryParse(id, out guid))
                {
                    throw new BadRequestException("El ID debe ser de tipo GUID.");
                }

                var company = await _query.RecoveryById(guid);

                var response = _mapper.Map<CompanyResponse>(company);
                response.Ubication = new UbicationResponse
                {
                    Province = company.CityObject.ProvinceObject.Name,
                    City = company.CityObject.Name
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

        Task<Paged<CompanyResponse>> IQueryService<CompanyResponse, string>.GetAllPaged(int pageNumber, int pageSize)
        {
            throw new NotImplementedException();
        }
    }
}
