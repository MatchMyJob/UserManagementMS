using Domain.Entities;

namespace Application.Interfaces
{
    public interface IContactInformationCommand : ICommand<ContactInformation, Guid>
    {
    }
}
