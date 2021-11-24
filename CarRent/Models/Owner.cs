using System;
using System.Collections.Generic;

namespace CarRent.Models
{
    public partial class Owner
    {
        public int OwnerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public int CarId { get; set; }

        public virtual Car Car { get; set; }
    }
}
