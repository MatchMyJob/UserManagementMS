﻿using Application.DTO.Error;
using Application.Interfaces;
using Domain.Entities;
using Infraestructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Command
{
    public class ApplicantCommand : IApplicantCommand
    {
        private readonly AppDbContext _context;

        public ApplicantCommand(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Applicant> Insert(Applicant entity)
        {
            await _context.AddAsync(entity);
            await _context.SaveChangesAsync();

            var applicant = await _context.Applicants
                .Include(c => c.CityObject)
                .ThenInclude(p => p.ProvinceObject)
                .FirstOrDefaultAsync(u => (u.UserId == entity.UserId) && (u.Status));

            return applicant;
        }

        public async Task Remove(Guid id)
        {
            var applicant = await _context.Applicants
                .FirstOrDefaultAsync(u => (u.UserId == id) && (u.Status));
            if (applicant == null)
            {
                throw new NotFoundException("El User con ID " + id + " no fue encontrado.");
            }   
            applicant.Status = false;
            await _context.SaveChangesAsync();
        }

        public async Task<Applicant> Update(Guid id, Applicant entity)
        {
            var applicant = await _context.Applicants
                .FirstOrDefaultAsync(u => (u.UserId == id) && (u.Status));
            if (applicant == null)
            {
                throw new NotFoundException("El User con ID " + id + " no fue encontrado.");
            }

            applicant.DNI = entity.DNI;
            applicant.Name = entity.Name;
            applicant.Surname = entity.Surname;
            applicant.BirthDate = entity.BirthDate;
            applicant.CityId = entity.CityId;
            applicant.Phone = entity.Phone;

            await _context.SaveChangesAsync();

            return applicant;
        }
    }
}
