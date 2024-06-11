using Application.DTO.Request;
using Application.DTO.Response;

namespace Application.Interfaces
{
    public interface IContactInformationCommandService : ICommandService<ContactInformationRequest, ContactInformationResponse, ContactInformationRequest, Guid>
    {
    }
}
