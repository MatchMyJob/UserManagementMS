using Application.DTO.Error;
using Application.DTO.Pagination;
using Application.DTO.Response;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;

namespace Application.UseCase.Services
{
    public class CompanyQueryService : ICompanyQueryService
    {
        private readonly ICompanyQuery _query;
        private readonly IMapper _mapper;
        private List<CompanyResponse> list;

        public CompanyQueryService(ICompanyQuery query, IMapper mapper)
        {
            _query = query;
            _mapper = mapper;
            list = new();
        }

        public async Task<Paged<CompanyResponse>> GetAllPaged(int pageNumber, int pageSize)
        {
            try
            {
                if (pageNumber <= 0 || pageSize <= 0)
                {
                    throw new BadRequestException("Ingrese valores mayores que cero (0) para pageNumber y pageSize");
                }
                Parameters parameters = new Parameters(pageNumber, pageSize);
                Paged<Company> companies = await _query.RecoveryAll(parameters);
                companies.Data.ForEach(e =>
                {
                    var companyResponse = _mapper.Map<CompanyResponse>(e);
                    companyResponse.Ubication = new UbicationResponse
                    {
                        Province = e.CityObject.ProvinceObject.Name,
                        City = e.CityObject.Name
                    };
                    list.Add(companyResponse);
                });

                return new Paged<CompanyResponse>(list, companies.MetaData.TotalCount, parameters.PageNumber, parameters.PageSize);
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

        public async Task<CompanyResponse> GetById(int id)
        {
            try
            {
                if (!(id >= 0))
                {
                    throw new BadRequestException("El ID no puede ser cero (0), ni un número menor.");
                }

                var company = await _query.RecoveryById(id);

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
    }
}
