using AutoMapper;
using CarRent.DTOs;
using CarRent.Models;
using CarRent.ViewModels;

namespace CarRent.Profiles
{
    public class ClientAdditionProfile : Profile
    {
        public ClientAdditionProfile()
        {
            CreateMap<ClientAddition, ClientAdditionView>().ReverseMap();
            CreateMap<ClientAddition, ClientAdditionDTO>().ReverseMap();
            CreateMap<ClientAdditionView, ClientAdditionDTO>().ReverseMap();
        }
    }
}
