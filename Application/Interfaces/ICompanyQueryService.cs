using Application.DTO.Response;

namespace Application.Interfaces
{
    public interface ICompanyQueryService : IQueryService<CompanyResponse, string>
    {
        Task<CompanyGetResponse> GetByCompanyId(int companyId);
    }
}
