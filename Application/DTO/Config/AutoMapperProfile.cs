using Application.DTO.Error;
using Application.DTO.Response;
using AutoMapper;

namespace Application.DTO.Config
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<HTTPError, HTTPResponse<string>>().ReverseMap();
        }
    }
}
