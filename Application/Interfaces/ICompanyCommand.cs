using Domain.Entities;

namespace Application.Interfaces
{
    public interface ICompanyCommand : ICommand<Company, Guid>
    {
    }
}
