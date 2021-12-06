using System;

namespace CarRent.DTOs
{
    public class BookingDTO
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int ReceivingAddressId { get; set; }
        public int ReturnAddressId { get; set; }
        public int CarId { get; set; }  
        public int ClientId { get; set; }
        public virtual ClientServiceDTO ClientService { get; set; }
    }
}
