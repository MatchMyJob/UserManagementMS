using Application.DTO.Error;
using Application.DTO.Response;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;

namespace Application.UseCase.Services
{
    public class ProvinceService : IProvinceService
    {
        private readonly IProvinceQuery _query;
        private readonly IMapper _mapper;
        private List<ProvinceResponse> responseList;
        public ProvinceService(IProvinceQuery ProvinceQuery, IMapper mapper)
        {
            _query = ProvinceQuery;
            _mapper = mapper;
            responseList = new();
        }
        public async Task<List<ProvinceResponse>> GetAllProvinceResponse()
        {
            try
            {
                List<Province> provinces = await _query.GetAllProvince();
                provinces.ForEach(e =>
                {
                    var provinceresponse = _mapper.Map<ProvinceResponse>(e);
                    responseList.Add(provinceresponse);
                }
                );
                return responseList;
            }
            catch (Exception e)
            {
                if (e is HTTPError)
                {
                    throw;
                }
                throw new InternalServerErrorException(e.Message);
            }
        }

        public async Task<ProvinceResponse> GetProvinceById(int provinceid)
        {
            try
            {
                if (provinceid <= 0)
                {
                    throw new BadRequestException("Ingrese valores mayores que cero (0) para ID ");
                }
                var province = await _query.GetProvinceById(provinceid);
                var response = _mapper.Map<ProvinceResponse>(province);
                (province.CityObjects).ForEach(city =>
                {
                    var entity = _mapper.Map<CityResponse>(city);
                    response.Cities.Add(entity);
                });
                return response;
            }
            catch (Exception e)
            {
                if (e is HTTPError)
                {
                    throw;
                }
                throw new InternalServerErrorException(e.Message);
            }
        }
    }
}
