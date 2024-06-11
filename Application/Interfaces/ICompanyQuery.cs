using Application.DTO.Pagination;
using Domain.Entities;

namespace Application.Interfaces
{
    public interface ICompanyQuery : IQuery<Company, Guid>
    {
        Task<Company> RecoveryByCompanyId(Guid companyId);
        Task<Paged<Company>> RecoveryAll(Parameters parameters, string? name);
    }
}
