using AutoMapper;
using CarRent.DTOs;
using CarRent.Models;
using CarRent.Services.Interfaces;
using CarRent.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CarRent.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _bookingSerice;
        private readonly IMapper _mapper;

        public BookingController(IBookingService bookingService, IMapper mapper)
        {
            _bookingSerice = bookingService;
            _mapper = mapper;
        }

        [HttpGet("{clientId}",Name = "GetAllBookingsByClientId")]
        public async Task<ActionResult<IEnumerable<BookingView>>> GetAllBookingsByClientId(int clientId)
        {
            var bookings = await _bookingSerice.GetBookingsByClientId(clientId);
            var bookingsView = _mapper.Map<IEnumerable<BookingView>>(bookings);
            return Ok(bookingsView);
        }

        [HttpGet("{id}", Name = "GetBookingById")]
        public async Task<ActionResult<BookingView>> GetBookingById(int id)
        {
            var booking = await _bookingSerice.GetBookingById(id);
            var bookingView = _mapper.Map<BookingView>(booking);
            return bookingView;
        }

        [HttpPost]
        public async Task<ActionResult<BookingView>> CreateBooking(BookingDTO bookingDTO)
        {
            var booking = _mapper.Map<Booking>(bookingDTO);
            await _bookingSerice.CreateBooking(booking);
            var bookingView = _mapper.Map<BookingView>(booking);
            return CreatedAtRoute(nameof(GetBookingById), new { Id = booking.BookingId }, bookingView);
        }
    }
}
