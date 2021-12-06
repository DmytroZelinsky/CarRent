using AutoMapper;
using CarRent.DTOs;
using CarRent.Models;
using CarRent.ViewModels;

namespace CarRent.Profiles
{
    public class ClientServiceProfile : Profile
    {
        public ClientServiceProfile()
        {
            CreateMap<ClientService, ClientServiceView>().ReverseMap();
            CreateMap<ClientService, ClientServiceDTO>().ReverseMap();
            CreateMap<ClientServiceView, ClientServiceDTO>().ReverseMap();
        }
    }
}
