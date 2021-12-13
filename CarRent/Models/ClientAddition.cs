using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarRent.Models
{
    public partial class ClientAddition
    {
        public int ClientAdditionId { get; set; }
        public bool HasChildSeat { get; set; }
        public bool HasWiFi { get; set; }
        public bool HasDriver { get; set; }
        public bool HasUnlimitedMileage { get; set; }
        public bool HasVideoRecorder { get; set; }
        public bool HasPhoneHolder { get; set; }
        [ForeignKey("Booking")]
        public int BookingId { get; set; }

        public virtual Booking Booking { get; set; }
    }
}
