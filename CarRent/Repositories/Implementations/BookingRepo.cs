using CarRent.Models;
using CarRent.Repositories.Interfaces;

namespace CarRent.Repositories.Implementations
{
    public class BookingRepo : BaseRepo<Booking>, IBookingRepo
    {
        public BookingRepo(CarRentDBContext dbContext) 
            : base(dbContext)
        {
        }
    }
}
