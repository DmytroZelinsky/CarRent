using System.Collections.Generic;

namespace CarRent.ViewModels
{
    public class AutoParkView
    {
        public int AutoParkId { get; set; }
        public int CurrentCarCount { get; set; }
        public virtual AddressView Address { get; set; }
        public virtual ICollection<CarView> Cars { get; set; }

    }
}
