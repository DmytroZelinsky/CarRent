﻿using System;
using System.Collections.Generic;

namespace CarRent.Models
{
    public partial class Client
    {
        public Client()
        {
            RoadAccidents = new HashSet<RoadAccident>();
        }

        public int ClientId { get; set; }
        public int AddressId { get; set; }
        public int BookingId { get; set; }
        public int ClientServiceId { get; set; }
        public int PaymentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PassportCode { get; set; }
        public string IdentificationCode { get; set; }
        public string LicenseCode { get; set; }
        public string PhoneNumber { get; set; }

        public virtual Address Address { get; set; }
        public virtual Booking Booking { get; set; }
        public virtual ClientService ClientService { get; set; }
        public virtual Payment Payment { get; set; }
        public virtual ICollection<RoadAccident> RoadAccidents { get; set; }
    }
}