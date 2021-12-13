using AutoMapper;
using CarRent.DTOs;
using CarRent.Models;
using CarRent.ViewModels;

namespace CarRent.Profiles
{
    public class CarRentInfoProfile : Profile
    {
        public CarRentInfoProfile()
        {
            CreateMap<CarRentInfo, CarRentInfoView>().ReverseMap();
            CreateMap<CarRentInfo, CarRentInfoDTO>().ReverseMap();
            CreateMap<CarRentInfoView, CarRentInfoDTO>().ReverseMap();
        }
    }
}
