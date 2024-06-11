using Application.DTO.Error;
using Application.DTO.Request;
using Application.DTO.Response;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using Microsoft.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Application.UseCase.Services
{
    public class ApplicantCommandService : IApplicantCommandService
    {
        private readonly IApplicantCommand _command;
        private readonly IMapper _mapper;

        public ApplicantCommandService(IApplicantCommand command, IMapper mapper)
        {
            _command = command;
            _mapper = mapper;
        }

        public async Task DeleteById(Guid id)
        {
            try
            {
                await _command.Remove(id);
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

        public async Task<ApplicantResponse> Update(Guid id, ApplicantUpdateRequest request)
        {
            try
            {
                if (!DateTime.TryParse(request.BirthDate, out _))
                {
                    throw new BadRequestException("Ingrese correctamente la fecha de nacimiento.");
                }
                if (!IsValidPhone(request.Phone.ToString()))
                {
                    throw new BadRequestException("Ingrese un formato valido: '54-1141462757' ");

                }
                if (!IsValidDNI(request.DNI.ToString()))
                {
                    throw new BadRequestException("Ingrese un número de DNI valido: '41539440'");
                }
                var applicant = _mapper.Map<Applicant>(request);
                applicant = await _command.Update(id, applicant);
                var response = _mapper.Map<ApplicantResponse>(applicant);
                response.Ubication = new UbicationResponse
                {
                    City = applicant.CityObject.Name,
                    Province = applicant.CityObject.ProvinceObject.Name
                };
                return response;
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
                        throw new ConflictException("Verifique la información a actualizar, la city no existe.");
                    }
                    if (sqlException.Number == 2601) // / Se comprueba si hay un duplicado
                    {
                        throw new ConflictException("Ya se encuentra el DNI.");
                    }
                }
                throw new InternalServerErrorException(e.Message);
            }
        }
        private bool IsValidPhone(string phone) 
        {
            string pattern = @"^[1-9][1-9]-\d{10}$";
            return Regex.IsMatch(phone, pattern);
        }
        private bool IsValidDNI(string dni)
        {
            string pattern = @"^\d{7,8}$|^\d{2}\\d{3}\\d{3}$";
            return Regex.IsMatch(dni, pattern);
        }

        public async Task<ApplicantResponse> RegisterApplicant(ApplicantRequest request, string userId)
        {
            try
            {
                if (!DateTime.TryParse(request.BirthDate, out _))
                {
                    throw new BadRequestException("Ingrese correctamente la fecha de nacimiento.");
                }
                if (!IsValidPhone(request.Phone.ToString()))
                {
                    throw new BadRequestException("Ingrese un formato valido: '54-1141462757' ");

                }
                if (!IsValidDNI(request.DNI.ToString()))
                {
                    throw new BadRequestException("Ingrese un número de DNI valido: '41539440'");
                }
                var applicant = _mapper.Map<Applicant>(request);
                applicant.UserId = Guid.Parse(userId);
                applicant.Status = true;
                applicant = await _command.Insert(applicant);


                var response = _mapper.Map<ApplicantResponse>(applicant);
                response.Ubication = new UbicationResponse
                {
                    Province = applicant.CityObject.ProvinceObject.Name,
                    City = applicant.CityObject.Name
                };
                return response;

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
                        throw new ConflictException("Verifique la información ingresada, el ID de City deben estar presentes.");
                    }
                    if (sqlException.Number == 2601) // / Se comprueba si hay un duplicado
                    {
                        throw new ConflictException("Ya se encuentra el DNI.");
                    }
                }
                throw new InternalServerErrorException(e.Message);
            }
        }

        public Task<ApplicantResponse> Create(ApplicantRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
