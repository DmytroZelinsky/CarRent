using AutoMapper;
using CarRent.DTOs;
using CarRent.Models;
using CarRent.ViewModels;

namespace CarRent.Profiles
{
    public class ClientOptionProfile : Profile
    {
        public ClientOptionProfile()
        {
            CreateMap<ClientOption, ClientOptionView>().ReverseMap();
            CreateMap<ClientOption, ClientOptionDTO>().ReverseMap();
            CreateMap<ClientOptionView, ClientOptionDTO>().ReverseMap();
        }
    }
}
