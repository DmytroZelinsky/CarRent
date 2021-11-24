using System;
using System.Collections.Generic;

namespace CarRent.Models
{
    public partial class UserInfoView
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string CarBrand { get; set; }
        public int Deposit { get; set; }
        public int PricePerDay { get; set; }
        public string City { get; set; }
        public int PaymentAmount { get; set; }
        public string HadAccidents { get; set; }
    }
}
