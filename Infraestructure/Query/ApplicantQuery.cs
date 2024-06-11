using Application.DTO.Error;
using Application.DTO.Pagination;
using Application.Interfaces;
using Domain.Entities;
using Infraestructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Query
{
    public class ApplicantQuery : IApplicantQuery
    {
        private readonly AppDbContext _context;

        public ApplicantQuery(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Paged<Applicant>> RecoveryAll(Parameters parameters, string? name)
        {
            IQueryable<Applicant> applicants = _context.Applicants.Where(a => a.Status)
                .Include(c => c.CityObject)
                .ThenInclude(p => p.ProvinceObject)
                .ThenInclude(c => c.CountryObject);

            if (!string.IsNullOrEmpty(name))
            {
                applicants = applicants.Where(p => p.Name.ToLower().Contains(name.ToLower()) || p.Surname.ToLower().Contains(name.ToLower()));
            }

            return await Paged<Applicant>.ToPagedAsync(applicants, parameters.PageNumber, parameters.PageSize);
        }

        public Task<Paged<Applicant>> RecoveryAll(Parameters parameters)
        {
            throw new NotImplementedException();
        }

        public async Task<Applicant> RecoveryById(Guid id)
        {
            var applicant = await _context.Applicants
                .Include(c => c.CityObject)
                .ThenInclude(p => p.ProvinceObject)
                .FirstOrDefaultAsync(a => (a.UserId == id) && (a.Status));
                
            if (applicant == null)
            {
                throw new NotFoundException("User con ID " + id + " no fue encontrado.");
            }
            return applicant;
        }
    }
}
