using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApplication.Data
{
    public class Room
    {
        [Key]
        [Required]
        [MaxLength(10)]
        public string RoomId { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public string ExtraBed { get; set; }
    }
}
