using System;
using System.Collections.Generic;

namespace CarRent.Models
{
    public partial class CarInfoView
    {
        public string Brand { get; set; }
        public int Deposit { get; set; }
        public int PricePerDay { get; set; }
        public int DistanceLimit { get; set; }
        public bool IsOccupied { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public string AddressName { get; set; }
        public int AddressNumber { get; set; }
    }
}
