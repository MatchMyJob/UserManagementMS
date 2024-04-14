using Application.DTO.Request;
using Application.DTO.Response;

namespace Application.Interfaces
{
    public interface IApplicantCommandService : ICommandService<ApplicantRequest, ApplicantResponse, ApplicantUpdateRequest, string>
    {

    }
}
