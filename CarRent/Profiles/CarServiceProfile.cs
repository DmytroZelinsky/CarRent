using AutoMapper;
using CarRent.DTOs;
using CarRent.Models;
using CarRent.ViewModels;

namespace CarRent.Profiles
{
    public class CarServiceProfile : Profile
    {
        public CarServiceProfile()
        {
            CreateMap<CarService, CarServiceView>().ReverseMap();
            CreateMap<CarService, CarServiceDTO>().ReverseMap();
            CreateMap<CarServiceView, CarServiceDTO>().ReverseMap();
        }
    }
}
