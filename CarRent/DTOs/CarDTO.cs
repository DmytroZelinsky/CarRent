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
        public int? AutoParkId { get; set; }
        public int? CarServiceId { get; set; }
        public string Vin { get; set; }
    }
}
