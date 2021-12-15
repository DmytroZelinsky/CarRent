using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarRent.Models
{
    public partial class ClientOption
    {
        public ClientOption()
        {
            Bookings = new HashSet<Booking>();
        }

        public int ClientOptionId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Booking> Bookings { get; set; }
    }
}
