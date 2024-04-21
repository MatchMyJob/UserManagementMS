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
        /// Retorna un Applicant especificando el ID
        /// </summary>
        /// <response code="200">Retorna un Applicant como resultado.</response>

        [HttpGet("{id}")]
        [Authorize(Roles = "jobuser, admin")]
        [ProducesResponseType(typeof(HTTPResponse<ApplicantResponse>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(HTTPResponse<string>), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(HTTPResponse<string>), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(HTTPResponse<string>), StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> GetById(string id)
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
        [Authorize(Roles = "admin")]
        [ProducesResponseType(typeof(HTTPResponse<Paged<ApplicantResponse>>), StatusCodes.Status200OK)]
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
        /// Registra un Applicant con su respectiva información
        /// </summary>
        /// <response code="201">Retorna el Applicant creado.</response>

        [HttpPost]
        [Authorize(Roles = "jobuser, admin")]
        [ProducesResponseType(typeof(HTTPResponse<ApplicantResponse>), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(HTTPResponse<string>), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(HTTPResponse<string>), StatusCodes.Status409Conflict)]
        [ProducesResponseType(typeof(HTTPResponse<string>), StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> CreateEntity(ApplicantRequest request)
        {
            try
            {
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
        /// Modifica un Applicant, especificando el ID y la nueva información
        /// </summary>
        /// <response code="200">Retorna el Applicant modificado como resultado.</response>

        [HttpPut("{id}")]
        [Authorize(Roles = "jobuser, admin")]
        [ProducesResponseType(typeof(HTTPResponse<ApplicantResponse>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(HTTPResponse<string>), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(HTTPResponse<string>), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(HTTPResponse<string>), StatusCodes.Status409Conflict)]
        [ProducesResponseType(typeof(HTTPResponse<string>), StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> UpdateEntity(string id, [FromBody] ApplicantUpdateRequest request)
        {
            try
            {
                _response.Result = await _commandService.Update(id, request);
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
        /// Modifica un dato de Applicant, especificando el dato a modificar y el ID
        /// </summary>
        /// <response code="200">Retorna el Applicant modificado.</response>

        [HttpPatch("{id}")]
        [Authorize(Roles = "jobuser, admin")]
        [ProducesResponseType(typeof(HTTPResponse<ApplicantResponse>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(HTTPResponse<string>), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(HTTPResponse<string>), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(HTTPResponse<string>), StatusCodes.Status409Conflict)]
        [ProducesResponseType(typeof(HTTPResponse<string>), StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> UpdatePartialEntity(string id, JsonPatchDocument<ApplicantUpdateRequest> patchRequest)
        {
            try
            {
                var applicant = await _queryService.GetById(id);
                ApplicantUpdateRequest applicantRequest = _mapper.Map<ApplicantUpdateRequest>(applicant);
                patchRequest.ApplyTo(applicantRequest, ModelState);
                if (!ModelState.IsValid)
                {
                    throw new BadRequestException("Ingresa los datos correctamente.");
                }

                _response.Result = await _commandService.Update(id, applicantRequest);
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
        /// Elimina un Applicant especificando su ID.
        /// </summary>
        /// <response code="200">No retorna nada.</response>

        [HttpDelete("{id}")]
        [Authorize(Roles = "jobuser, admin")]
        [ProducesResponseType(typeof(HTTPResponse<string>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(HTTPResponse<string>), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(HTTPResponse<string>), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(HTTPResponse<string>), StatusCodes.Status409Conflict)]
        [ProducesResponseType(typeof(HTTPResponse<string>), StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> DeleteById(string id)
        {
            try
            {
                await _commandService.DeleteById(id);
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
