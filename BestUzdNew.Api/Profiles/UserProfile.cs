using AutoMapper;
using BestUzdNew.Api.Dtos.Input;
using BestUzdNew.Domain.Entities;

namespace BestUzdNew.Api.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserInformationInDto, UserInformation>().ReverseMap();
            CreateMap<UserInDto, User>()
                .ForMember(x => x.UserInformation, x => x.MapFrom(z => z.UserInfo)).ReverseMap();
        }
    }
}
