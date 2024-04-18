using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IProvinceService
    {
        public Task<List<Province>> GetAllProvince();
        public Task<Province> GetProvinceById(int provinceid);
    }
}
