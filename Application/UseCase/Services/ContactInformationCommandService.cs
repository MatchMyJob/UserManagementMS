using Application.DTO.Error;
using Application.DTO.Request;
using Application.DTO.Response;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using Microsoft.Data.SqlClient;

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
                if (!(request.CompanyId >= 0))
                {
                    throw new BadRequestException("El ID no puede ser cero (0), ni un número menor.");
                }

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
                        throw new ConflictException("La Company ya tiene asociada información de contacto.");
                    }
                }
                throw new ConflictException("Verifique la información ingresada, el ID debe ser único.");
            }
        }

        public Task DeleteById(int id)
        {
            throw new NotImplementedException(); //sin implementar, no va a ser necesario
        }

        public async Task<ContactInformationResponse> Update(int id, ContactInformationRequest request)
        {
            try
            {
                if (!(id >= 0))
                {
                    throw new BadRequestException("El ID no puede ser cero (0), ni un número menor.");
                }
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
    }
}
