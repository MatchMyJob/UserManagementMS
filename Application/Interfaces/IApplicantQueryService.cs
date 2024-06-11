using Application.DTO.Pagination;
using Application.DTO.Response;
namespace Application.Interfaces
{
    public interface IApplicantQueryService : IQueryService<ApplicantResponse, Guid>
    {
        Task<Paged<ApplicantMinimalResponse>> GetAllPaged(int pageNumber, int pageSize, string? name);
    }
}
