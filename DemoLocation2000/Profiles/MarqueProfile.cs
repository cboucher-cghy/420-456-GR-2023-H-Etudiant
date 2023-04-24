using AutoMapper;
using DemoLocation2000.Models;
using DemoLocation2000.ViewModels;

namespace DemoLocation2000.Profiles
{
    public class MarqueProfile : Profile
    {
        public MarqueProfile()
        {
            CreateMap<Marque, MarqueCreateVM>()
                .ForMember(x => x.NomMarque, opt => opt.MapFrom(x => x.Nom))
                .ReverseMap();
        }
    }
}
