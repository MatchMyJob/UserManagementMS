using Application.DTO.Error;
using Application.DTO.Pagination;
using Application.DTO.Response;
using Application.Interfaces;
using AutoMapper;

namespace Application.UseCase.Services
{
    public class ContactInformationQueryService : IContactInformationQueryService
    {
        private readonly IContactInformationQuery _query;
        private readonly IMapper _mapper;

        public ContactInformationQueryService(IContactInformationQuery query, IMapper mapper)
        {
            _query = query;
            _mapper = mapper;
        }

        public Task<Paged<ContactInformationResponse>> GetAllPaged(int pageNumber, int pageSize)
        {
            throw new NotImplementedException(); //sin implementar, no va a ser necesario
        }

        public async Task<ContactInformationResponse> GetById(Guid id)
        {
            try
            {
                var contactInformation = await _query.RecoveryById(id);

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
