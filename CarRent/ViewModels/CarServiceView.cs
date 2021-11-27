namespace CarRent.ViewModels
{
    public class CarServiceView
    {
        public int CarServiceId { get; set; }
        public int DistanceLimit { get; set; }
        public bool IsOccupied { get; set; }
        public int PricePerDay { get; set; }
        public int Deposit { get; set; }
    }
}
