using Application.DTO.Response;

namespace Application.Interfaces
{
    public interface IProvinceService
    {
        public Task<List<ProvinceResponse>> GetAllProvinceResponse();
        public Task<ProvinceResponse> GetProvinceById(int provinceId);
    }
}
