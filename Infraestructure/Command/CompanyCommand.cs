using Application.DTO.Error;
using Application.Interfaces;
using Domain.Entities;
using Infraestructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Command
{
    public class CompanyCommand : ICompanyCommand
    {
        private readonly AppDbContext _context;

        public CompanyCommand(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Company> Insert(Company entity)
        {
            try
            {
                await _context.AddAsync(entity);
                await _context.SaveChangesAsync();

                var company = await _context.Companies
                    .Include(c => c.CityObject)
                    .ThenInclude(p => p.ProvinceObject)
                    .FirstOrDefaultAsync(u => (u.CompanyId == entity.CompanyId) && (u.Status));

                return company;
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public async Task Remove(Guid id)
        {
            var company = await _context.Companies
                .FirstOrDefaultAsync(u => (u.CompanyId == id) && (u.Status));
            if (company == null)
            {
                throw new NotFoundException("La Company con el ID " + id + " no fue encontrada.");
            }
            company.Status = false;
            await _context.SaveChangesAsync();
        }

        public async Task<Company> Update(Guid id, Company entity)
        {
            var company = await _context.Companies
                .FirstOrDefaultAsync(u => (u.CompanyId == id) && (u.Status));
            if (company == null)
            {
                throw new NotFoundException("La Company con el ID " + id + " no fue encontrada.");
            }
            company.CityId = entity.CityId;
            company.CUIT = entity.CUIT;
            company.Phone = entity.Phone;
            company.BusinessName = entity.BusinessName;
            company.BusinessSector = entity.BusinessSector;
            company.Address = entity.Address;
            company.Website = entity.Website;
            company.Description = entity.Description;
            company.Logo = entity.Logo;            

            await _context.SaveChangesAsync();

            company = await _context.Companies
                .Include(c => c.CityObject)
                .ThenInclude(p => p.ProvinceObject)
                .FirstOrDefaultAsync(u => (u.CompanyId == id) && (u.Status));

            return company;
        }
    }
}
