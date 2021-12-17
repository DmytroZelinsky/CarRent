using CarRent.Models;
using System;
using System.Collections.Generic;

namespace CarRent.ViewModels
{
    public class BookingView
    {
        public int BookingId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime? ActualEndDate { get; set; }

        public virtual AddressView ReceivingAddress { get; set; }
        public virtual AddressView ReturnAddress { get; set; }
        public virtual AddressView ActualReturnAddress { get; set; }
        public virtual CarView Car { get; set; }
        //public virtual ClientView Client { get; set; }
        public virtual BillingView Billing { get; set; }
        public virtual ICollection<ClientOptionView> ClientOptions { get; set; }
    }
}
