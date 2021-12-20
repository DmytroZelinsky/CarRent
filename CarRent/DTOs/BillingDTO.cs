using CarRent.Enums;
using System;

namespace CarRent.DTOs
{
    public class BillingDTO
    {
        public InvoiceStatus Status { get; set; }
        public DateTime? PaymentDate { get; set; }
        public PaymentMethod Method { get; set; }
        public int TotalAmount { get; set; }
    }
}
