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
                if (request.UserId == Guid.Empty)
                {
                    throw new BadRequestException("El UserId no puede ser 0 u otro valor.");
                }

                if (!DateTime.TryParse(request.BirthDate, out _))
                {
                    throw new BadRequestException("Ingrese correctamente la fecha de nacimiento.");
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
                        throw new ConflictException("Verifique la información ingresada, el ID del User y de City deben estar presentes.");
                    }
                }
                throw new ConflictException("Verifique la información ingresada, los identificadores como DNI o ID deben ser únicos.");
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
                var applicant = _mapper.Map<Applicant>(request);
                applicant = await _command.Update(guid, applicant);

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
                throw new InternalServerErrorException(e.Message);
            }
        }
    }
}
