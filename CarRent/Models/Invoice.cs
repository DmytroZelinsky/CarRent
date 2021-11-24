using System;
using System.Collections.Generic;

namespace CarRent.Models
{
    public partial class Invoice
    {
        public Invoice()
        {
            Payments = new HashSet<Payment>();
        }

        public int InvoiceId { get; set; }
        public int ClientServiceId { get; set; }
        public int InvioceStatus { get; set; }
        public int InvoiceAmount { get; set; }

        public virtual ClientService ClientService { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
    }
}
