using Domain.Entities;

namespace Application.Interfaces
{
    public interface ICompanyQuery : IQuery<Company, Guid>
    {
        Task<Company> RecoveryByCompanyId(int companyId);
        
    }
}
