using Application.DTO.Error;
using Application.DTO.Request;
using Application.DTO.Response;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.FileSystemGlobbing.Internal;
using System.Text.RegularExpressions;

namespace Application.UseCase.Services
{
    public class ContactInformationCommandService : IContactInformationCommandService
    {
        private readonly IContactInformationCommand _command;
        private readonly IMapper _mapper;

        public ContactInformationCommandService(IContactInformationCommand command, IMapper mapper)
        {
            _command = command;
            _mapper = mapper;
        }

        public async Task<ContactInformationResponse> Create(ContactInformationRequest request)
        {
            try
            {
                IsValidPhone(request.Phone);
                IsValidEmail(request.Email);

                var contactInformation = _mapper.Map<ContactInformation>(request);
                contactInformation = await _command.Insert(contactInformation);

                return _mapper.Map<ContactInformationResponse>(contactInformation);
            }
            catch (Exception e)
            {
                if (e is HTTPError)
                {
                    throw;
                }
                if (e.InnerException is SqlException sqlException)
                {
                    if (sqlException.Number == 547) // / Se comprueba si hay una violación de clave externa
                    {
                        throw new BadRequestException("Ingrese el ID de una Company existente.");
                    }
                }
                throw new ConflictException("La Company ya tiene asociada información de contacto.");
            }
        }

        public Task DeleteById(Guid id)
        {
            throw new NotImplementedException(); //sin implementar, no va a ser necesario
        }

        public async Task<ContactInformationResponse> Update(Guid id, ContactInformationRequest request)
        {
            try
            {
                IsValidPhone(request.Phone);
                IsValidEmail(request.Email);

                var contactInformation = _mapper.Map<ContactInformation>(request);
                contactInformation = await _command.Update(id, contactInformation);

                return _mapper.Map<ContactInformationResponse>(contactInformation);
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

        private void IsValidPhone(string phone)
        {
            string pattern = @"^[1-9][1-9]-\d{10}$";
            if (!Regex.IsMatch(phone, pattern))
            {
                throw new BadRequestException("Ingrese un formato valido para Phone: '54-1141462757' ");
            }
        }

        private void IsValidEmail(string email)
        {
            string pattern = @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$";
            if (!Regex.IsMatch(email, pattern))
            {
                throw new BadRequestException("Ingrese un Email válido.");
            }
        }
    }
}
