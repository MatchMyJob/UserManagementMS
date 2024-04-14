using Application.DTO.Error;
using Application.DTO.Request;
using Application.DTO.Response;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;

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
                var applicant = _mapper.Map<Applicant>(request);
                applicant = await _command.Insert(applicant);

                return _mapper.Map<ApplicantResponse>(applicant);
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

                return _mapper.Map<ApplicantResponse>(applicant);
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
