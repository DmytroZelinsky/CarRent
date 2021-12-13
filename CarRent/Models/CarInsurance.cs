using System;
using System.Collections.Generic;

namespace CarRent.Models
{
    public partial class CarInsurance
    {
        public int CarInsuranceId { get; set; }
        public string InsuranceCompanyName { get; set; }
        public string PolicyNumber { get; set; }
        public DateTime EffectiveDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public int CarRentInfoId { get; set; }

        public virtual CarRentInfo CarRentInfo { get; set; }  
    }
}
