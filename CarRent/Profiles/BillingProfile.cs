using AutoMapper;
using CarRent.DTOs;
using CarRent.Models;
using CarRent.ViewModels;

namespace CarRent.Profiles
{
    public class BillingProfile : Profile
    {
        public BillingProfile()
        {
            CreateMap<Billing, BillingView>().ReverseMap();
            CreateMap<Billing, BillingDTO>().ReverseMap();
            CreateMap<BillingView, BillingDTO>().ReverseMap();
        }
    }
}
