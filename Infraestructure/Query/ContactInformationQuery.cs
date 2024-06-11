using Application.DTO.Error;
using Application.DTO.Pagination;
using Application.Interfaces;
using Domain.Entities;
using Infraestructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Query
{
    public class ContactInformationQuery : IContactInformationQuery
    {
        private readonly AppDbContext _context;

        public ContactInformationQuery(AppDbContext context)
        {
            _context = context;
        }

        public Task<Paged<ContactInformation>> RecoveryAll(Parameters parameters)
        {
            throw new NotImplementedException(); //sin implementar, no va a ser necesario
        }

        public async Task<ContactInformation> RecoveryById(Guid id)
        {
            var company = await _context.ContactInformations
                .FirstOrDefaultAsync(c => (c.CompanyId == id));

            if (company == null)
            {
                throw new NotFoundException("La información solicitada no fue encontrada.");
            }
            return company;
        }
    }
}
