using Application.DTO.Error;
using Application.DTO.Request;
using Application.DTO.Response;
using AutoMapper;
using Domain.Entities;

namespace Application.DTO.Config
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<HTTPError, HTTPResponse<string>>().ReverseMap();
            CreateMap<ApplicantResponse, Applicant>().ReverseMap();
            CreateMap<Applicant, ApplicantRequest>().ReverseMap();
            CreateMap<ApplicantUpdateRequest, Applicant>().ReverseMap();
        }
    }
}
