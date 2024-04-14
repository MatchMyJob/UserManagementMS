using Application.DTO.Pagination;

namespace Application.Interfaces
{
    public interface IQuery<T, ID> where T : class
    {
        Task<Paged<T>> RecoveryAll(Parameters parameters);
        Task<T> RecoveryById(ID id);
    }
}
