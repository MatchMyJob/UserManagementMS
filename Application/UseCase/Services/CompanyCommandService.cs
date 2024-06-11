using Application.DTO.Error;
using Application.DTO.Request;
using Application.DTO.Response;
using Application.Interfaces;
using AutoMapper;
using Azure.Core;
using Domain.Entities;
using Microsoft.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Application.UseCase.Services
{
    public class CompanyCommandService : ICompanyCommandService
    {
        private readonly ICompanyCommand _command;
        private readonly IMapper _mapper;

        public CompanyCommandService(ICompanyCommand command, IMapper mapper)
        {
            _command = command;
            _mapper = mapper;
        }

        public async Task<CompanyResponse> RegisterCompany(CompanyRequest request, string userId)
        {
            try
            {
                if (!IsValidPhone(request.Phone.ToString()))
                {
                    throw new BadRequestException("Ingrese un formato valido: '54-1141462757' ");

                }
                if (!IsValidCuit(request.CUIT))
                {
                    throw new BadRequestException("Ingrese un formato valido para CUIT: '30-87654321-2' ");
                }

                var id = Guid.Parse(userId);

                var company = _mapper.Map<Company>(request);
                company.CompanyId = id;
                company.Status = true;
                company = await _command.Insert(company);

                var response = _mapper.Map<CompanyResponse>(company);
                response.Ubication = new UbicationResponse
                {
                    Province = company.CityObject.ProvinceObject.Name,
                    City = company.CityObject.Name
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
                    if (sqlException.Number == 2627)
                    {
                        // 2627 is the error number for a unique constraint violation in SQL Server
                        throw new ConflictException("Ya hay una cuenta registrada para el ID asociado.");
                    }
                }
                throw new InternalServerErrorException(e.Message);
            }
        }

        public Task<CompanyResponse> Create(CompanyRequest request)
        {
            throw new NotImplementedException();
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

        public async Task<CompanyResponse> Update(string id, CompanyUpdateRequest request)
        {
            try
            {
                Guid guid;
                if (!Guid.TryParse(id, out guid))
                {
                    throw new BadRequestException("El ID debe ser de tipo GUID.");
                }
                if (!IsValidPhone(request.Phone))
                {
                    throw new BadRequestException("Ingrese un formato valido para Phone: '54-1141462757' ");

                }
                if (!IsValidCuit(request.CUIT))
                {
                    throw new BadRequestException("Ingrese un formato valido para CUIT: '30-87654321-2' ");
                }

                var company = _mapper.Map<Company>(request);
                company = await _command.Update(guid, company);

                var response = _mapper.Map<CompanyResponse>(company);
                response.Ubication = new UbicationResponse
                {
                    Province = company.CityObject.ProvinceObject.Name,
                    City = company.CityObject.Name
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
                        throw new ConflictException("Verifique la información ingresada, el ID de City deben estar presente.");
                    }
                }
                throw new ConflictException("Verifique la información ingresada, IDs deben ser únicos.");
            }
        }

        private bool IsValidPhone(string phone)
        {
            string pattern = @"^[1-9][1-9]-\d{10}$";
            return Regex.IsMatch(phone, pattern);
        }

        private bool IsValidCuit(string cuit)
        {
            string pattern = @"^\d{2}-\d{7,9}-\d$";
            return Regex.IsMatch(cuit, pattern);
        }

        
    }
}
