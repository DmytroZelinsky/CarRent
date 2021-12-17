using AutoMapper;
using AutoMapper.Internal;
using CarRent.DTOs;
using CarRent.Models;
using CarRent.Repositories.Interfaces;
using CarRent.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRent.Services.Implementations
{
    public class BookingService : IBookingService
    {
        private readonly IBookingRepo _bookingRepo;
        private readonly IClientOptionRepo _clientOptionRepo;
        private readonly IMapper _mapper;

        public BookingService(IBookingRepo bookingRepo, IClientOptionRepo  clientOptionRepo, IMapper mapper)
        {
            _bookingRepo = bookingRepo;
            _clientOptionRepo = clientOptionRepo;
            _mapper = mapper;
        }

        public async Task<IEnumerable<Booking>> GetBookingsByCarId(int carId)
        {
            return await _bookingRepo.GetAllAsync(x => x.CarId == carId);
        }

        public async Task<IEnumerable<Booking>> GetBookingsByClientId(int clientId)
        {
            return await _bookingRepo.GetAllAsync(x => x.ClientId == clientId);
        }
        public async Task<Booking> CreateBooking(BookingDTO bookingDTO)
        {
            var booking = _mapper.Map<Booking>(bookingDTO);
            var clientOptions = await _clientOptionRepo.GetAllAsync(x => bookingDTO.ClientOptionIds.Contains(x.ClientOptionId));
            clientOptions.ForAll(x => booking.ClientOptions.Add(x));
            await _bookingRepo.CreateAsync(booking);
            await _bookingRepo.SaveChangesAsync();
            return booking;
        }

        public async Task<Booking> GetBookingById(int id)
        {
            return await _bookingRepo.GetFirstAsync(
                predicate: x => x.BookingId == id,
                include: source => source
                    .Include(x => x.ReceivingAddress)
                    .Include(x => x.ReturnAddress)
                    .Include(x => x.ActualReturnAddress)
                    .Include(x => x.Client)
                    .Include(x => x.Car)
                    .Include(x => x.ClientOptions)
                    .Include(x => x.Billing));
        }
    }
}
