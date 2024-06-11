using Application.DTO.Request;
using Application.DTO.Response;

namespace Application.Interfaces
{
    public interface IApplicantCommandService : ICommandService<ApplicantRequest, ApplicantResponse, ApplicantUpdateRequest, Guid>
    {
        Task<ApplicantResponse> RegisterApplicant(ApplicantRequest request, string userId);
    }
}
