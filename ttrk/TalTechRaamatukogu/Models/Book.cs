using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TalTechRaamatukogu.Models
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime DateOfPublication { get; set; }
        public int Floor { get; set; }
        public int Rack { get; set; }
        public string BookID { get; set; }
        public bool Status { get; set; }
        public DateTime DateOfReturn { get; set; }

        public Customer Customer { get; set; }
        public string CustomerID { get; internal set; }
    }
}
