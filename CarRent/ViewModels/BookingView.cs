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

        public virtual Address ReceivingAddress { get; set; }
        public virtual Address ReturnAddress { get; set; }
        public virtual Address ActualReturnAddress { get; set; }
        public virtual Client Client { get; set; }
        public virtual Car Car { get; set; }
        public virtual Billing Billing { get; set; }
    }
}
