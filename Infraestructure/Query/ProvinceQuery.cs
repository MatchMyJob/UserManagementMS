using Application.Interfaces;
using Domain.Entities;
using Infraestructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Query
{
    public class ProvinceQuery : IProvinceQuery
    {
        private readonly AppDbContext _context;
        public ProvinceQuery(AppDbContext DBcontext)
        {
            this._context = DBcontext;
        }
        public async Task<List<Province>> GetAllProvince()
        {
            List<Province> AllCountrys = await _context.Provinces
                .Include(p => p.CountryObject)
                .ToListAsync();
            return AllCountrys;
        }
        public async Task<Province> GetProvinceById(int provinceid)
        {
            return _context.Provinces.SingleOrDefault(p => p.ProvinceId == provinceid);
        }
    }
}
