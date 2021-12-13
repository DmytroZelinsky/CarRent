using CarRent.Enums;
using System.Collections.Generic;

namespace CarRent.ViewModels
{
    public class CarView
    {
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

        public virtual CarRentInfoView CarRentInfo { get; set; }
    }
}
