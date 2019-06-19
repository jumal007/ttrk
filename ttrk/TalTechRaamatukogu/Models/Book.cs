using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TalTechRaamatukogu.Models
{
    public class Book
    {
        private readonly Random r;
        [StringLength(50)]
        public string Title { get; set; }
        [StringLength(50)]
        public string Author { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date of publication")]
        public DateTime DateOfPublication { get; set; }
        [Range(0,9)]
        public int Floor { get; set; }
        [Range(10, 99)]
        public int Rack { get; set; }
        [Display(Name = "Book ID")]
        [ForeignKey("BookID")]
        //public string BookID
        //{
        //    get
        //    {
        //        return Floor.ToString() + Rack.ToString() + r.Next(10000, 99999).ToString();
        //    }
        //}
        public string BookID { get; set; }
        public bool Status { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date of return")]
        public DateTime DateOfReturn { get; set; }

        public Customer Customer { get; set; }
        public string CustomerID { get; internal set; }
    }
}
