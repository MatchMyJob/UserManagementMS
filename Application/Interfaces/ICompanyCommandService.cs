using Application.DTO.Request;
using Application.DTO.Response;

namespace Application.Interfaces
{
    public interface ICompanyCommandService : ICommandService<CompanyRequest, CompanyResponse, CompanyUpdateRequest, string>
    {
    }
}
