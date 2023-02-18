using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApplication.Data
{
    public class Guest
    {
            [Key]
            public string? GuestId { get; set; }
            public string? Name { get; set; }
            public int Age { get; set; } 
    }
}
