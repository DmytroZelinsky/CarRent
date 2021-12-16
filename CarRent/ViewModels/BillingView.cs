using System;

namespace CarRent.ViewModels
{
    public class BillingView
    {
        public int BillingId { get; set; }
        public int Status { get; set; }
        public DateTime? PaymentDate { get; set; }
        public string Method { get; set; }
        public int TotalAmount { get; set; }
    }
}
