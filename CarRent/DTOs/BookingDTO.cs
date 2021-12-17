using System;
using System.Collections.Generic;

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

        public BillingDTO Billing { get; set; }

        public ICollection<int> ClientOptionIds { get; set; }
    }
}
