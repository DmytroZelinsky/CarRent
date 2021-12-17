using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarRent.Models
{
    public partial class CarRentInfo
    {
        public int CarRentInfoId { get; set; }
        public int DistanceLimit { get; set; }
        public bool IsOccupied { get; set; }
        public int PricePerDay { get; set; }
        public int Deposit { get; set; }
        [ForeignKey("Car")]
        public int CarId { get; set; }

        public virtual Car Car { get; set; }
    }
}
