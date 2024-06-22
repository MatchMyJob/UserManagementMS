using Application.DTO.Error;
using Application.DTO.Pagination;
using Application.DTO.Request;
using Application.DTO.Response;
using Application.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Security.Claims;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicantController : ControllerBase
    {
        private readonly IApplicantQueryService _queryService;
        private readonly IApplicantCommandService _commandService;
        private readonly IMapper _mapper;
        private HTTPResponse<Object> _response;

        public ApplicantController(IApplicantQueryService queryService, IApplicantCommandService commandService, IMapper mapper)
        {
            _queryService = queryService;
            _commandService = commandService;
            _mapper = mapper;
            _response = new();
        }

        /// <summary>
        /// Retorna la información del Applicant
        /// </summary>
        /// <response code="200">Retorna un Applicant como resultado.</response>

        [HttpGet("Me")]
        [Authorize(Roles = "jobuser")]
        [ProducesResponseType(typeof(HTTPResponse<ApplicantResponse>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(HTTPResponse<string>), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(HTTPResponse<string>), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(HTTPResponse<string>), StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> GetById()
        {
            try
            {
                var userId = Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)); // Obtengo el ID del token

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
        /// Retorna la información del Applicant dado un ID
        /// </summary>
        /// <response code="200">Retorna un Applicant como resultado.</response>

        [HttpGet("{id:Guid}")]
        //[Authorize(Roles = "company, admin")]
        [ProducesResponseType(typeof(HTTPResponse<ApplicantResponse>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(HTTPResponse<string>), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(HTTPResponse<string>), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(HTTPResponse<string>), StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> GetById(Guid id)
        {
            try
            {
                _response.Result = await _queryService.GetById(id);
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
        /// Retorna una pagina de Applicants
        /// </summary>
        /// <response code="200">Retorna una pagina de Applicants como resultado.</response>

        [HttpGet]
        [ProducesResponseType(typeof(HTTPResponse<Paged<ApplicantResponse>>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(HTTPResponse<string>), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(HTTPResponse<string>), StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> GetAll(
            [FromQuery] string? name, 
            int pagedNumber = 1, 
            int pagedSize = 10
            )
        {
            try
            {
                _response.Result = await _queryService.GetAllPaged(pagedNumber, pagedSize, name);
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
        /// Registra al Applicant con su respectiva información
        /// </summary>
        /// <response code="201">Retorna el Applicant creado.</response>

        [HttpPost]
        [Authorize(Roles = "jobuser")]
        [ProducesResponseType(typeof(HTTPResponse<ApplicantResponse>), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(HTTPResponse<string>), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(HTTPResponse<string>), StatusCodes.Status409Conflict)]
        [ProducesResponseType(typeof(HTTPResponse<string>), StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> CreateEntity([FromBody] ApplicantRequest request)
        {
            try
            {
                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier); // Obtengo el ID del token

                _response.Result = await _commandService.RegisterApplicant(request, userId);
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
        /// Modifica al Applicant, especificando la nueva información
        /// </summary>
        /// <response code="200">Retorna el Applicant modificado como resultado.</response>

        [HttpPut("Me")]
        [Authorize(Roles = "jobuser")]
        [ProducesResponseType(typeof(HTTPResponse<ApplicantResponse>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(HTTPResponse<string>), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(HTTPResponse<string>), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(HTTPResponse<string>), StatusCodes.Status409Conflict)]
        [ProducesResponseType(typeof(HTTPResponse<string>), StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> UpdateEntity([FromBody] ApplicantUpdateRequest request)
        {
            try
            {
                var userId = Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)); // Obtengo el ID del token

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
        /// Elimina al Applicant.
        /// </summary>
        /// <response code="200">No retorna nada.</response>

        [HttpDelete("Me")]
        [Authorize(Roles = "jobuser")]
        [ProducesResponseType(typeof(HTTPResponse<string>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(HTTPResponse<string>), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(HTTPResponse<string>), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(HTTPResponse<string>), StatusCodes.Status409Conflict)]
        [ProducesResponseType(typeof(HTTPResponse<string>), StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> DeleteById()
        {
            try
            {
                var userId = Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)); // Obtengo el ID del token

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
