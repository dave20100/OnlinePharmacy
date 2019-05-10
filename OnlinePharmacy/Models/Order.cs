using Microsoft.AspNetCore.Mvc.ModelBinding;
using OnlinePharmacy.Migrations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlinePharmacy.Models
{
    public class Order
    {
        [BindNever]
        public int OrderID { get; set; }
        [BindNever]
        public ICollection<CartLine> Lines { get; set; }

        [Required(ErrorMessage = "Please enter a name")]
        public string Name { get; set; }
        
        [Required(ErrorMessage ="Please enter the address")]
        public string Address { get; set; }
        
        [Required(ErrorMessage = "Please enter a city name")]
        public string City { get; set; }
        
        public string Zip { get; set; }
        
        public Prescription Prescription { get; set; }
    }
}
