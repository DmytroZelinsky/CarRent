using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarRent.Models
{
    public partial class Billing
    {
        public int BillingId { get; set; }
        public int Status { get; set; }
        public DateTime? PaymentDate { get; set; }
        public string Method { get; set; }
        public int TotalAmount { get; set; }
        [ForeignKey("Booking")]
        public int BookingId { get; set; }

        public virtual Booking Booking { get; set; }
    }
}
