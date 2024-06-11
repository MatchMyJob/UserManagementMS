using Application.DTO.Pagination;
using Application.DTO.Response;

namespace Application.Interfaces
{
    public interface ICompanyQueryService : IQueryService<CompanyResponse, string>
    {
        Task<CompanyGetResponse> GetByCompanyId(Guid companyId);
        Task<Paged<CompanyMinimalResponse>> GetCompanyByFilter(int pageNumber, int pageSize, string? name);
    }
}
