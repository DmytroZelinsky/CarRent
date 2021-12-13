using System;

namespace CarRent.Models
{
    public partial class Booking
    {
        public int BookingId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime? ActualEndDate { get; set; }
        public int ReceivingAddressId { get; set; }
        public int ReturnAddressId { get; set; }
        public int? ActualReturnAddressId { get; set; }
        public int ClientId { get; set; }
        public int CarId { get; set; }
        public int BillingId { get; set; }
        public int ClientAdditionId { get; set; }

        public virtual Address ReceivingAddress { get; set; }
        public virtual Address ReturnAddress { get; set; }
        public virtual Address ActualReturnAddress { get; set; }
        public virtual Client Client { get; set; }
        public virtual Car Car { get; set; }
        public virtual Billing Billing { get; set; }
        public virtual ClientAddition ClientAddition { get; set; }
    }
}
