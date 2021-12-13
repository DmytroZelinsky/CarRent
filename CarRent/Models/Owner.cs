using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarRent.Models
{
    public partial class Owner
    {
        public Owner()
        {
            Cars = new HashSet<Car>();
        }
        public int OwnerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }

        public virtual ICollection<Car> Cars { get; set; }
    }
}
