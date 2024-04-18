using Application.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCase.Services
{
    public class ProvinceService : IProvinceService
    {
        private readonly IProvinceQuery _query;
        public ProvinceService(IProvinceQuery ProvinceQuery) 
        {
            _query = ProvinceQuery;
        }
        public async Task<List<Province>> GetAllProvince()
        {
            List<Province> AllProvince = await _query.GetAllProvince();
            return AllProvince;
        }
        public async Task<Province> GetProvinceById(int provinceid)
        {
            return await _query.GetProvinceById(provinceid);
        }
    }
}
