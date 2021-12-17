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
        private readonly IBookingService _bookingService;
        private readonly IMapper _mapper;

        public BookingController(IBookingService bookingService, IMapper mapper)
        {
            _bookingService = bookingService;
            _mapper = mapper;
        }

        //[HttpGet("{clientId}",Name = "GetAllBookingsByClientId")]
        //public async Task<ActionResult<IEnumerable<BookingView>>> GetAllBookingsByClientId(int clientId)
        //{
        //    var bookings = await _bookingSerice.GetBookingsByClientId(clientId);
        //    var bookingsView = _mapper.Map<IEnumerable<BookingView>>(bookings);
        //    return Ok(bookingsView);
        //}

        [HttpGet("{id}", Name = "GetBookingById")]
        public async Task<ActionResult<BookingView>> GetBookingById(int id)
        {
            var booking = await _bookingService.GetBookingById(id);
            var bookingView = _mapper.Map<BookingView>(booking);
            return Ok(bookingView);
        }

        [HttpPost]
        public async Task<ActionResult<BookingView>> CreateBooking(BookingDTO bookingDTO)
        {
            var booking = await _bookingService.CreateBooking(bookingDTO);
            var bookingView = _mapper.Map<BookingView>(await _bookingService.GetBookingById(booking.BookingId));
            return CreatedAtRoute(nameof(GetBookingById), new { Id = bookingView.BookingId }, bookingView);
        }
    }
}
