using System;
using System.Collections.Generic;

namespace CarRent.Models
{
    public partial class Booking
    {
        public Booking()
        {
            Clients = new HashSet<Client>();
        }

        public int BookingId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime? ActualEndDate { get; set; }
        public int ReceivingAddressId { get; set; }
        public int ReturnAddressId { get; set; }
        public int? ActualReturnAddressId { get; set; }

        public Address ReceivingAddress { get; set; }
        public Address ReturnAddress { get; set; }
        public Address ActualReturnAddress { get; set; }

        public virtual ICollection<Client> Clients { get; set; }
    }
}
