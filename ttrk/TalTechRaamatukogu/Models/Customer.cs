using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TalTechRaamatukogu.Models
{
    public class Customer
    {
        [StringLength(50,MinimumLength = 3)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [StringLength(50, MinimumLength = 3)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Deposit")]
        public int Dept { get; set; }
        [StringLength(11, MinimumLength = 11)]
        [Display(Name = "ID")]
        public string CustomerID { get; set; } //it is ID of estonian citizens
        [Display(Name = "E-mail")]
        public string Email { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
