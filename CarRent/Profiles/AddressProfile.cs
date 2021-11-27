using AutoMapper;
using CarRent.DTOs;
using CarRent.Models;
using CarRent.ViewModels;

namespace CarRent.Profiles
{
    public class AddressProfile : Profile
    {
        public AddressProfile()
        {
            CreateMap<Address, AddressView>().ReverseMap();
            CreateMap<Address, AddressDTO>().ReverseMap();
            CreateMap<AddressView, AddressDTO>().ReverseMap();
        }
    }
}
