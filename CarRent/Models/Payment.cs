using System;
using System.Collections.Generic;

namespace CarRent.Models
{
    public partial class Payment
    {
        public Payment()
        {
            Clients = new HashSet<Client>();
        }

        public int PaymentId { get; set; }
        public int InvoiceId { get; set; }
        public DateTime PaymentDate { get; set; }
        public int PaymentAmount { get; set; }
        public string PaymentMethod { get; set; }
        public int PaymentStatus { get; set; }

        public virtual Invoice Invoice { get; set; }
        public virtual ICollection<Client> Clients { get; set; }
    }
}
