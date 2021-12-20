using CarRent.Enums;
using System;

namespace CarRent.ViewModels
{
    public class BillingView
    {
        public InvoiceStatus Status { get; set; }
        public DateTime? PaymentDate { get; set; }
        public PaymentMethod Method { get; set; }
        public int TotalAmount { get; set; }
    }
}
