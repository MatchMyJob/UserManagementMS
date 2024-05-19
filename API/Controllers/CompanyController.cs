using Application.DTO.Error;
using Application.DTO.Pagination;
using Application.DTO.Request;
using Application.DTO.Response;
using Application.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Security.Claims;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyQueryService _queryService;
        private readonly ICompanyCommandService _commandService;
        private readonly IMapper _mapper;
        private HTTPResponse<Object> _response;

        public CompanyController(ICompanyQueryService queryService, ICompanyCommandService commandService, IMapper mapper)
        {
            _queryService = queryService;
            _commandService = commandService;
            _mapper = mapper;
            _response = new();
        }

        /// <summary>
        /// Retorna la información de la Company
        /// </summary>
        /// <response code="200">Retorna una Company como resultado.</response>

        [HttpGet("Me")]
        [Authorize(Roles = "company")]
        [ProducesResponseType(typeof(HTTPResponse<CompanyResponse>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(HTTPResponse<string>), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(HTTPResponse<string>), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(HTTPResponse<string>), StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> GetById()
        {
            try
            {
                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier); // Obtengo el ID del token

                _response.Result = await _queryService.GetById(userId);
                _response.StatusCode = (HttpStatusCode)200;
                _response.Status = "OK";
                return new JsonResult(_response) { StatusCode = 200 };
            }
            catch (Exception e)
            {
                if (e is HTTPError)
                {
                    return new JsonResult(_mapper.Map<HTTPResponse<string>>(e)) { StatusCode = (int)((HTTPError)e).StatusCode };
                }
                return new JsonResult(_mapper.Map<HTTPResponse<string>>(new InternalServerErrorException("Ha ocurrido un error en el servicodor."))) { StatusCode = 500 };
            }
        }


        /// <summary>
        /// Retorna una pagina de Companies
        /// </summary>
        /// <response code="200">Retorna una pagina de Companies como resultado.</response>

        [HttpGet]
        [Authorize(Roles = "admin")]
        [ProducesResponseType(typeof(HTTPResponse<Paged<CompanyResponse>>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(HTTPResponse<string>), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(HTTPResponse<string>), StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> GetAll(int pagedNumber = 1, int pagedSize = 10)
        {
            try
            {
                _response.Result = await _queryService.GetAllPaged(pagedNumber, pagedSize);
                _response.StatusCode = (HttpStatusCode)200;
                _response.Status = "OK";
                return new JsonResult(_response) { StatusCode = 200 };
            }
            catch (Exception e)
            {
                if (e is HTTPError)
                {
                    return new JsonResult(_mapper.Map<HTTPResponse<string>>(e)) { StatusCode = (int)((HTTPError)e).StatusCode };
                }
                return new JsonResult(_mapper.Map<HTTPResponse<string>>(new InternalServerErrorException("Ha ocurrido un error en el servicodor."))) { StatusCode = 500 };
            }
        }


        /// <summary>
        /// Registra la Company con su respectiva información
        /// </summary>
        /// <response code="201">Retorna la Company creada.</response>

        [HttpPost]
        [Authorize(Roles = "company")]
        [ProducesResponseType(typeof(HTTPResponse<CompanyResponse>), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(HTTPResponse<string>), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(HTTPResponse<string>), StatusCodes.Status409Conflict)]
        [ProducesResponseType(typeof(HTTPResponse<string>), StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> CreateEntity(CompanyRequest request)
        {
            try
            {
                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier); // Obtengo el ID del token
                request.UserId = userId;

                _response.Result = await _commandService.Create(request);
                _response.StatusCode = (HttpStatusCode)201;
                _response.Status = "Created";
                return new JsonResult(_response) { StatusCode = 201 };
            }
            catch (Exception e)
            {
                if (e is HTTPError)
                {
                    return new JsonResult(_mapper.Map<HTTPResponse<string>>(e)) { StatusCode = (int)((HTTPError)e).StatusCode };
                }
                return new JsonResult(_mapper.Map<HTTPResponse<string>>(new InternalServerErrorException("Ha ocurrido un error en el servicodor."))) { StatusCode = 500 };
            }
        }


        /// <summary>
        /// Modifica la Company, especificando la nueva información
        /// </summary>
        /// <response code="200">Retorna la Company modificado como resultado.</response>

        [HttpPut("Me")]
        [Authorize(Roles = "company")]
        [ProducesResponseType(typeof(HTTPResponse<CompanyResponse>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(HTTPResponse<string>), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(HTTPResponse<string>), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(HTTPResponse<string>), StatusCodes.Status409Conflict)]
        [ProducesResponseType(typeof(HTTPResponse<string>), StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> UpdateEntity([FromBody] CompanyUpdateRequest request)
        {
            try
            {
                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier); // Obtengo el ID del token

                _response.Result = await _commandService.Update(userId, request);
                _response.StatusCode = (HttpStatusCode)200;
                _response.Status = "OK";
                return new JsonResult(_response) { StatusCode = 200 };
            }
            catch (Exception e)
            {
                if (e is HTTPError)
                {
                    return new JsonResult(_mapper.Map<HTTPResponse<string>>(e)) { StatusCode = (int)((HTTPError)e).StatusCode };
                }
                return new JsonResult(_mapper.Map<HTTPResponse<string>>(new InternalServerErrorException("Ha ocurrido un error en el servicodor."))) { StatusCode = 500 };
            }
        }


        /// <summary>
        /// Modifica un dato de la Company, especificando el dato a modificar
        /// </summary>
        /// <response code="200">Retorna la Company modificada.</response>

        [HttpPatch("Me")]
        [Authorize(Roles = "company")]
        [ProducesResponseType(typeof(HTTPResponse<CompanyResponse>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(HTTPResponse<string>), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(HTTPResponse<string>), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(HTTPResponse<string>), StatusCodes.Status409Conflict)]
        [ProducesResponseType(typeof(HTTPResponse<string>), StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> UpdatePartialEntity(JsonPatchDocument<CompanyUpdateRequest> patchRequest)
        {
            try
            {
                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier); // Obtengo el ID del token

                var company = await _queryService.GetById(userId);
                CompanyUpdateRequest companyRequest = _mapper.Map<CompanyUpdateRequest>(company);
                patchRequest.ApplyTo(companyRequest, ModelState);
                if (!ModelState.IsValid)
                {
                    throw new BadRequestException("Ingresa los datos correctamente.");
                }

                _response.Result = await _commandService.Update(userId, companyRequest);
                _response.StatusCode = (HttpStatusCode)200;
                _response.Status = "OK";
                return new JsonResult(_response) { StatusCode = 200 };
            }
            catch (Exception e)
            {
                if (e is HTTPError)
                {
                    return new JsonResult(_mapper.Map<HTTPResponse<string>>(e)) { StatusCode = (int)((HTTPError)e).StatusCode };
                }
                return new JsonResult(_mapper.Map<HTTPResponse<string>>(new InternalServerErrorException("Ha ocurrido un error en el servicodor."))) { StatusCode = 500 };
            }
        }




        /// <summary>
        /// Elimina la Company.
        /// </summary>
        /// <response code="200">No retorna nada.</response>

        [HttpDelete("Me")]
        [Authorize(Roles = "company")]
        [ProducesResponseType(typeof(HTTPResponse<string>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(HTTPResponse<string>), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(HTTPResponse<string>), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(HTTPResponse<string>), StatusCodes.Status409Conflict)]
        [ProducesResponseType(typeof(HTTPResponse<string>), StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> DeleteById()
        {
            try
            {
                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier); // Obtengo el ID del token

                await _commandService.DeleteById(userId);
                _response.StatusCode = (HttpStatusCode)200;
                _response.Status = "OK";
                return new JsonResult(_response) { StatusCode = 200 };
            }
            catch (Exception e)
            {
                if (e is HTTPError)
                {
                    return new JsonResult(_mapper.Map<HTTPResponse<string>>(e)) { StatusCode = (int)((HTTPError)e).StatusCode };
                }
                return new JsonResult(_mapper.Map<HTTPResponse<string>>(new InternalServerErrorException("Ha ocurrido un error en el servicodor."))) { StatusCode = 500 };
            }
        }
    }
}
