using AutoMapper;
using BestUzdNew.Api.Dtos.Input;
using BestUzdNew.Api.Dtos.Output;
using BestUzdNew.Domain.Entities;

namespace BestUzdNew.Api.Profiles
{
    public class ServiceProfile : Profile
    {
        public ServiceProfile()
        {
            CreateMap<ServiceInDto, Service>();
            CreateMap<Service, ServiceOutDto>();
        }
    }
}
