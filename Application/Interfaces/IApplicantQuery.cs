using Application.DTO.Pagination;
using Domain.Entities;

namespace Application.Interfaces
{
    public interface IApplicantQuery : IQuery<Applicant, Guid>
    {
        Task<Paged<Applicant>> RecoveryAll(Parameters parameters, string? name);
    }
}
