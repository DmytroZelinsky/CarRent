using System;
using System.Collections.Generic;

namespace CarRent.Models
{
    public partial class AutoPark
    {
        public AutoPark()
        {
            Cars = new HashSet<Car>();
        }

        public int AutoParkId { get; set; }
        public int MaxCarCount { get; set; }
        public int CurrentCarCount { get; set; }
        public int AddressId { get; set; }

        public virtual Address Address { get; set; }
        public virtual ICollection<Car> Cars { get; set; }
    }
}
