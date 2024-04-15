using Application.DTO.Error;
using Application.DTO.Request;
using Application.DTO.Response;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using Microsoft.Data.SqlClient;

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

        public async Task<CompanyResponse> Create(CompanyRequest request)
        {
            try
            {
                if (request.UserId == Guid.Empty)
                {
                    throw new BadRequestException("El UserId no puede ser 0 u otro valor.");
                }

                var company = _mapper.Map<Company>(request);
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
                }
                throw new ConflictException("Verifique la información ingresada, los identificadores como CUIL o ID deben ser únicos.");
            }
        }

        public async Task DeleteById(int id)
        {
            try
            {
                if (id > 0)
                {
                    throw new BadRequestException("El ID no puede ser cero (0), ni un número menor.");
                }
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

        public async Task<CompanyResponse> Update(int id, CompanyUpdateRequest request)
        {
            try
            {
                if (id > 0)
                {
                    throw new BadRequestException("El ID no puede ser cero (0), ni un número menor.");
                }
                var company = _mapper.Map<Company>(request);
                company = await _command.Update(id, company);

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
                throw new InternalServerErrorException(e.Message);
            }
        }
    }
}
