using AutoMapper;
using BestUzdNew.Api.Dtos.Input;
using BestUzdNew.Domain.Entities;

namespace BestUzdNew.Api.Profiles
{
    public class TranslationProfile : Profile
    {
        public TranslationProfile()
        {
            CreateMap<TranslationInDto, Translation>()
                .ForMember(x => x.Translation1, x => x.MapFrom(z => z.Translation))
                .ReverseMap();
        }
    }
}
