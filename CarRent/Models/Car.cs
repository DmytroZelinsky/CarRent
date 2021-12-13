using CarRent.Enums;
using System;
using System.Collections.Generic;

namespace CarRent.Models
{
    public partial class Car
    {
        public Car()
        {
            RoadAccidents = new HashSet<RoadAccident>();
            Bookings = new HashSet<Booking>();
            Clients = new HashSet<Client>();
        }

        public int CarId { get; set; }
        public string Type { get; set; }
        public double EngineVolume { get; set; }
        public Geerbox Geerbox { get; set; }
        public FuelType FuelType { get; set; }
        public DriveType DriveType { get; set; }
        public string Brand { get; set; }
        public string Vin { get; set; }
        public string Model { get; set; }
        public Class Class { get; set; }
        public int AutoParkId { get; set; } 
        public int? OwnerId { get; set; }
        public int CarRentInfoId { get; set; }

        public virtual AutoPark AutoPark { get; set; }
        public virtual Owner Owner { get; set; }
        public virtual CarRentInfo CarRentInfo { get; set; }

        public virtual ICollection<RoadAccident> RoadAccidents { get; set; }
        public virtual ICollection<Booking> Bookings { get; set; }
        public virtual ICollection<Client> Clients { get; set; }
    }
}
