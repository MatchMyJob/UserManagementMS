using Application.DTO.Error;
using Application.DTO.Pagination;
using Application.Interfaces;
using Domain.Entities;
using Infraestructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Query
{
    public class CompanyQuery : ICompanyQuery
    {
        private readonly AppDbContext _context;

        public CompanyQuery(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Company> RecoveryByCompanyId(Guid companyId)
        {
            var company = await _context.Companies
                .Include(c => c.CityObject)
                .ThenInclude(p => p.ProvinceObject)
                .FirstOrDefaultAsync(c => (c.CompanyId == companyId) && (c.Status));

            if (company == null)
            {
                throw new NotFoundException("La Company con el ID " + companyId + " no fue encontrada.");
            }
            return company;
        }

        public async Task<Paged<Company>> RecoveryAll(Parameters parameters, string? name)
        {
            IQueryable<Company> companies = _context.Companies.Where(a => a.Status)
                .Include(c => c.CityObject)
                    .ThenInclude(p => p.ProvinceObject)
                        .ThenInclude(c => c.CountryObject);

            if (!string.IsNullOrEmpty(name))
            {
                companies = companies.Where(p => p.BusinessName.ToLower().Contains(name.ToLower()));
            }

            return await Paged<Company>.ToPagedAsync(companies, parameters.PageNumber, parameters.PageSize);
        }

        public async Task<Company> RecoveryById(Guid id)
        {
            var company = await _context.Companies
                .Include(c => c.CityObject)
                .ThenInclude(p => p.ProvinceObject)
                .FirstOrDefaultAsync(c => (c.CompanyId == id) && (c.Status));

            if (company == null)
            {
                throw new NotFoundException("La Company con el ID " + id + " no fue encontrada.");
            }
            return company;
        }

        public Task<Paged<Company>> RecoveryAll(Parameters parameters)
        {
            throw new NotImplementedException();
        }
    }
}
