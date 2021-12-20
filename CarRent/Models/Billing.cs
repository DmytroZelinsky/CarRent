using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CarRent.Enums;

namespace CarRent.Models
{
    public partial class Billing
    {
        [Key]
        [ForeignKey("Booking")]
        public int BookingId { get; set; }
        public InvoiceStatus Status { get; set; }
        public DateTime? PaymentDate { get; set; }
        public PaymentMethod Method { get; set; }
        public int TotalAmount { get; set; }

        public virtual Booking Booking { get; set; }
    }
}
