using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace gymapp.Models
{
    public class Room
    {
        public int RoomID { get; set; }
        [Required]
        public string Name { get; set; }
    }

}