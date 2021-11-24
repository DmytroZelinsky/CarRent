using System;
using System.Collections.Generic;

namespace CarRent.Models
{
    public partial class Address
    {
        public Address()
        {
            AutoParks = new HashSet<AutoPark>();
            Clients = new HashSet<Client>();
        }

        public int AddressId { get; set; }
        public string City { get; set; }
        public string AddressName { get; set; }
        public int AddressNumber { get; set; }
        public int PostCode { get; set; }

        public virtual ICollection<AutoPark> AutoParks { get; set; }
        public virtual ICollection<Client> Clients { get; set; }
    }
}
