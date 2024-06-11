using Application.DTO.Response;

namespace Application.Interfaces
{
    public interface IContactInformationQueryService : IQueryService<ContactInformationResponse, Guid>
    {
    }
}
