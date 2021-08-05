using AutoMapper;
using BestUzdNew.Api.Dtos.Input;
using BestUzdNew.Api.Dtos.Output;
using BestUzdNew.Domain.Entities;

namespace BestUzdNew.Api.Profiles
{
    public class ServiceGroupProfile : Profile
    {
        public ServiceGroupProfile()
        {
            CreateMap<ServiceGroupInDto, ServiceGroup>()
                .ForMember(x => x.NameAlias, x => x.MapFrom(z => z.NameAlias))
                .ReverseMap();
        }
    }
}
