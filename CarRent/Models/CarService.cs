using System;
using System.Collections.Generic;

namespace CarRent.Models
{
    public partial class CarService
    {
        public CarService()
        {
            Cars = new HashSet<Car>();
        }

        public int CarServiceId { get; set; }
        public int DistanceLimit { get; set; }
        public bool IsOccupied { get; set; }
        public int PricePerDay { get; set; }
        public int Deposit { get; set; }
        public int CarInsuranceId { get; set; }

        public virtual CarInsurance CarInsurance { get; set; }
        public virtual ICollection<Car> Cars { get; set; }
    }
}
