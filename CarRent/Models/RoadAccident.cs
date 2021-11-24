using System;
using System.Collections.Generic;

namespace CarRent.Models
{
    public partial class RoadAccident
    {
        public int RoadAccidentId { get; set; }
        public int ClientId { get; set; }
        public int CarId { get; set; }
        public string ProtocolNumber { get; set; }

        public virtual Car Car { get; set; }
        public virtual Client Client { get; set; }
    }
}
