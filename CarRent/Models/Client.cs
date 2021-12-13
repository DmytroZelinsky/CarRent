using System;
using System.Collections.Generic;

namespace CarRent.Models
{
    public partial class Client
    {
        public Client()
        {
            RoadAccidents = new HashSet<RoadAccident>();
            Bookings = new HashSet<Booking>();
            Cars = new HashSet<Car>();
        }

        public int ClientId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PassportCode { get; set; }
        public string IdentificationCode { get; set; }
        public string LicenseCode { get; set; }
        public string PhoneNumber { get; set; }
        public int AddressId { get; set; }

        public virtual Address Address { get; set; }

        public virtual ICollection<RoadAccident> RoadAccidents { get; set; }
        public virtual ICollection<Booking> Bookings { get; set; }
        public virtual ICollection<Car> Cars { get; set; }
    }
}
