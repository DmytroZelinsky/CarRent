using System;
using System.Collections.Generic;

namespace CarRent.Models
{
    public partial class CarInsurance
    {
        public CarInsurance()
        {
            CarServices = new HashSet<CarService>();
        }

        public int CarInsuranceId { get; set; }
        public string InsuranceCompanyName { get; set; }
        public int InsuranceCompanyAddressId { get; set; }
        public string PolicyNumber { get; set; }
        public DateTime EffectiveDate { get; set; }
        public DateTime ExpirationDate { get; set; }

        public virtual ICollection<CarService> CarServices { get; set; }
    }
}
