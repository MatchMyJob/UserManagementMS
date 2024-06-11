using Application.DTO.Error;
using Application.Interfaces;
using Domain.Entities;
using Infraestructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Command
{
    public class ContactInformationCommand : IContactInformationCommand
    {
        private readonly AppDbContext _context;

        public ContactInformationCommand(AppDbContext context)
        {
            _context = context;
        }

        public async Task<ContactInformation> Insert(ContactInformation entity)
        {
            await _context.AddAsync(entity);
            await _context.SaveChangesAsync();

            var contactInformation = await _context.ContactInformations
                .FirstOrDefaultAsync(ci => ci.CompanyId == entity.CompanyId);

            return contactInformation;
        }

        public Task Remove(Guid id)
        {
            throw new NotImplementedException(); //sin implementar, no va a ser necesario
        }

        public async Task<ContactInformation> Update(Guid id, ContactInformation entity)
        {
            var contactInformation = await _context.ContactInformations
                .FirstOrDefaultAsync(ci => ci.CompanyId == id);
            if (contactInformation == null)
            {
                throw new NotFoundException("La información solicitada no fue encontrada.");
            }

            contactInformation.Name = entity.Name;
            contactInformation.Surname = entity.Surname;
            contactInformation.Phone = entity.Phone;
            contactInformation.Email = entity.Email;

            await _context.SaveChangesAsync();

            return contactInformation;
        }
    }
}
