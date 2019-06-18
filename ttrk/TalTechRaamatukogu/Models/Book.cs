using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TalTechRaamatukogu.Models
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateOfPublication { get; set; }
        public int Floor { get; set; }
        [StringLength(1)]
        public int Rack { get; set; }
        [StringLength(2)]
        public string BookID { get; set; }
        [StringLength(8,MinimumLength = 8)]
        public bool Status { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateOfReturn { get; set; }

        public Customer Customer { get; set; }
        public string CustomerID { get; internal set; }
    }
}
