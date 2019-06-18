using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TalTechRaamatukogu.Models
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Dept { get; set; }
        public string CustomerID { get; set; } //it is ID of estonian citizens
        [StringLength(11, MinimumLength = 11)]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}
