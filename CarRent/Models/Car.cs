using CarRent.Enums;
using System;
using System.Collections.Generic;

namespace CarRent.Models
{
    public partial class Car
    {
        public Car()
        {
            Owners = new HashSet<Owner>();
            RoadAccidents = new HashSet<RoadAccident>();
            Bookings = new HashSet<Booking>();
        }

        public int CarId { get; set; }
        public string Type { get; set; }
        public double EngineVolume { get; set; }
        public string Geerbox { get; set; }
        public string FuelType { get; set; }
        public string DriveType { get; set; }
        public string Brand { get; set; }
        public int? AutoParkId { get; set; }
        public int? CarServiceId { get; set; }
        public string Vin { get; set; }
        public string Model { get; set; }
        public Class Class { get; set; }

        public virtual AutoPark AutoPark { get; set; }
        public virtual CarService CarService { get; set; }
        public virtual ICollection<Owner> Owners { get; set; }
        public virtual ICollection<RoadAccident> RoadAccidents { get; set; }
        public virtual ICollection<Booking> Bookings { get; set; }
    }
}
