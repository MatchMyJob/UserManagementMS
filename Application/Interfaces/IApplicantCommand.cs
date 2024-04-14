using Application.DTO.Request;
using Domain.Entities;

namespace Application.Interfaces
{
    public interface IApplicantCommand : ICommand<Applicant, Guid>
    {

    }
}
