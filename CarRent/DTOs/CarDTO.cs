using CarRent.Enums;

namespace CarRent.DTOs
{
    public class CarDTO
    {
        public string Type { get; set; }
        public double EngineVolume { get; set; }
        public Geerbox Geerbox { get; set; }
        public FuelType FuelType { get; set; }
        public DriveType DriveType { get; set; }
        public string Brand { get; set; }
        public virtual AutoParkDTO AutoPark { get; set; }
        public virtual CarRentInfoDTO CarRentInfo { get; set; }
        public string Vin { get; set; }
        public string Model { get; set; }
        public Class Class { get; set; }
    }
}
