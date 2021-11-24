using System;
using System.Collections.Generic;

namespace CarRent.Models
{
    public partial class ClientService
    {
        public ClientService()
        {
            Clients = new HashSet<Client>();
            Invoices = new HashSet<Invoice>();
        }

        public int ClientServiceId { get; set; }
        public bool HasChildSeat { get; set; }
        public bool HasWiFi { get; set; }
        public bool HasDriver { get; set; }
        public bool OneWay { get; set; }

        public virtual ICollection<Client> Clients { get; set; }
        public virtual ICollection<Invoice> Invoices { get; set; }
    }
}
