using AutoMapper;
using CarRent.DTOs;
using CarRent.Models;
using CarRent.ViewModels;

namespace CarRent.Profiles
{
    public class AutoParkProfile : Profile
    {
        public AutoParkProfile()
        {
            CreateMap<AutoPark, AutoParkView>().ReverseMap();
            CreateMap<AutoPark, AutoParkDTO>().ReverseMap();
            CreateMap<AutoParkView, AutoParkDTO>().ReverseMap();
        }
    }
}
