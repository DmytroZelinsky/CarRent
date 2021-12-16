using System;

namespace CarRent.DTOs
{
    public class BillingDTO
    {
        public int Status { get; set; }
        public DateTime? PaymentDate { get; set; }
        public string Method { get; set; }
        public int TotalAmount { get; set; }
    }
}
