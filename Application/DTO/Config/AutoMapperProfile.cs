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

            CreateMap<Applicant, ApplicantResponse>().ReverseMap();
            CreateMap<Applicant, ApplicantMinimalResponse>().ReverseMap();
            CreateMap<Applicant, ApplicantRequest>().ReverseMap();
            CreateMap<Applicant, ApplicantUpdateRequest>().ReverseMap();
            CreateMap<ApplicantRequest, Applicant>()
                .ForMember(dest => dest.BirthDate, opt => opt.MapFrom(src => DateOnly.Parse(src.BirthDate)));
            CreateMap<ApplicantUpdateRequest, Applicant>()
                .ForMember(dest => dest.BirthDate, opt => opt.MapFrom(src => DateOnly.Parse(src.BirthDate)));

            CreateMap<Company, CompanyRequest>().ReverseMap();
            CreateMap<Company, CompanyResponse>().ReverseMap();
            CreateMap<Company, CompanyGetResponse>().ReverseMap();
            CreateMap<Company, CompanyMinimalResponse>().ReverseMap();
            CreateMap<Company, CompanyUpdateRequest>().ReverseMap();

            CreateMap<ContactInformation, ContactInformationResponse>().ReverseMap();
            CreateMap<ContactInformation, ContactInformationRequest>().ReverseMap();

            CreateMap<Province, ProvinceResponse>().ReverseMap();

            CreateMap<City, CityResponse>().ReverseMap();
        }
    }
}
