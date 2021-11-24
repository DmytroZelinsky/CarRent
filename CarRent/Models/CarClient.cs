using System;
using System.Collections.Generic;

namespace CarRent.Models
{
    public partial class CarClient
    {
        public int CarId { get; set; }
        public int ClientId { get; set; }

        public virtual Car Car { get; set; }
        public virtual Client Client { get; set; }
    }
}
