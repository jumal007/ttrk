using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ttrk.Data
{
    public class @book
    {
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
    }
}
