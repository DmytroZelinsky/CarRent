using CarRent.Models;
using CarRent.Repositories.Interfaces;
using CarRent.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CarRent.Services.Implementations
{
    public class BookingService : IBookingService
    {
        private readonly IBookingRepo _bookingRepo;

        public BookingService(IBookingRepo bookingRepo)
        {
            _bookingRepo = bookingRepo;
        }

        public async Task<IEnumerable<Booking>> GetBookingsByCarId(int carId)
        {
            return await _bookingRepo.GetAllAsync(x => x.CarId == carId);
        }

        public async Task<IEnumerable<Booking>> GetBookingsByClientId(int clientId)
        {
            return await _bookingRepo.GetAllAsync(x => x.ClientId == clientId);

        }
        public async Task CreateBooking(Booking booking)
        {
            await _bookingRepo.CreateAsync(booking);
            await _bookingRepo.SaveChangesAsync();
        }

        public async Task<Booking> GetBookingById(int id)
        {
            return await _bookingRepo.GetFirstAsync(x => x.BookingId == id);
        }
    }
}
