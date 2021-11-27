using CarRent.Models;

namespace CarRent.DTOs
{
    public class CarServiceDTO
    {
        public int DistanceLimit { get; set; }
        public int PricePerDay { get; set; }
        public int Deposit { get; set; }
    }
}
