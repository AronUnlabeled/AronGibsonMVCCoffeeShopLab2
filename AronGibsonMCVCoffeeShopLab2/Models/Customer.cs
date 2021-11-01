using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace AronGibsonMCVCoffeeShopLab2
{
    public partial class Customer
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool LactoseIntolerant { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
