using AutoMapper;
using CarRent.DTOs;
using CarRent.Models;
using CarRent.ViewModels;

namespace CarRent.Profiles
{
    public class BookingProfile : Profile
    {
        public BookingProfile()
        {
            CreateMap<Booking, BookingView>().ReverseMap();
            CreateMap<Booking, BookingDTO>().ReverseMap();
            CreateMap<BookingView, BookingDTO>().ReverseMap();
        }
    }
}
