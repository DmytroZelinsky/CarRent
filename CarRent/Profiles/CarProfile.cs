using AutoMapper;
using CarRent.DTOs;
using CarRent.Models;
using CarRent.ViewModels;

namespace CarRent.Profiles
{
    public class CarProfile : Profile
    {
        public CarProfile()
        {
            CreateMap<Car, CarView>().ReverseMap();
            CreateMap<Car, CarDTO>().ReverseMap();
            CreateMap<CarView, CarDTO>().ReverseMap();
        }
    }
}
