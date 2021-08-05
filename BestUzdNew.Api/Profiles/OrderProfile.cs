using AutoMapper;
using BestUzdNew.Api.Dtos.Input;
using BestUzdNew.Domain.Entities;

namespace BestUzdNew.Api.Profiles
{
    public class OrderProfile : Profile
    {
        public OrderProfile()
        {
            CreateMap<OrderInDto, Order>()
                .ForMember(x => x.ServiceId, x => x.MapFrom(z => z.ServiceId))
                .ReverseMap();
        }
    }
}
