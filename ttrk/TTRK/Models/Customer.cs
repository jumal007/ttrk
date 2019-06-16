using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Open.TTRK.Models
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Dept { get; set; }
        public string CustomerID { get; set; }
        public DateTime DateOfBirth { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}
