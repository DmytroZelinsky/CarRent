using CarRent.DTOs;
using CarRent.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CarRent.Services.Interfaces
{
    public interface IBookingService
    {
        Task<IEnumerable<Booking>> GetBookingsByClientId(int clientId);
        Task<IEnumerable<Booking>> GetBookingsByCarId(int carId);
        Task<Booking> GetBookingById(int id);
        Task<Booking> CreateBooking(BookingDTO booking);
    }
}
