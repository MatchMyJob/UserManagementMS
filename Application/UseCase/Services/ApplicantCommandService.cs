using Application.DTO.Error;
using Application.DTO.Request;
using Application.DTO.Response;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using System.Diagnostics;
using System.Net;
using System.Runtime.ConstrainedExecution;
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

        public async Task<ApplicantResponse> Create(ApplicantRequest request)
        {
            try
            {
                if(request == null)
                {
                    throw new BadRequestException("el ID no puede ser vacio");
                }
                if (request.UserId == Guid.Empty)
                {
                    throw new BadRequestException("El UserId no puede ser 0 u otro valor.");
                }

                if (!DateTime.TryParse(request.BirthDate, out _))
                {
                    throw new BadRequestException("Ingrese correctamente la fecha de nacimiento.");
                }
                if (!IsValidPhone(request.Phone.ToString()))
                {
                    throw new BadRequestException("Ingrese un formato valido: '54-1141462757' ");

                }
                if (!IsValidDNI(request.Dni.ToString()))
                {
                    throw new BadRequestException("Ingrese un número de DNI valido: '41539440'");
                }
                var applicant = _mapper.Map<Applicant>(request);
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

        public async Task DeleteById(string id)
        {
            try
            {
                Guid guid;
                if (!Guid.TryParse(id, out guid))
                {
                    throw new BadRequestException("El ID debe ser de tipo GUID.");
                }
                await _command.Remove(guid);
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

        public async Task<ApplicantResponse> Update(string id, ApplicantUpdateRequest request)
        {
            try
            {
                Guid guid;
                if (!Guid.TryParse(id, out guid))
                {
                    throw new BadRequestException("El ID debe ser de tipo GUID.");
                }
                if (!DateTime.TryParse(request.BirthDate, out _))
                {
                    throw new BadRequestException("Ingrese correctamente la fecha de nacimiento.");
                }
                if (!IsValidPhone(request.Phone.ToString()))
                {
                    throw new BadRequestException("Ingrese un formato valido: '54-1141462757' ");

                }
                if (!IsValidDNI(request.Dni.ToString()))
                {
                    throw new BadRequestException("Ingrese un número de DNI valido: '41539440'");
                }
                var applicant = _mapper.Map<Applicant>(request);
                applicant = await _command.Update(guid, applicant);
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
    }
}
