using CarRent.Enums;

namespace CarRent.DTOs
{
    public class CarDTO
    {
        public string Type { get; set; }
        public double EngineVolume { get; set; }
        public string Geerbox { get; set; }
        public string FuelType { get; set; }
        public string DriveType { get; set; }
        public string Brand { get; set; }
        public virtual AutoParkDTO AutoPark { get; set; }
        public virtual CarServiceDTO CarService { get; set; }
        public string Vin { get; set; }
        public string Model { get; set; }
        public Class Class { get; set; }
    }
}
