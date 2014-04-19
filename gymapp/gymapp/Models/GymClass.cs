using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace gymapp.Models
{
    public class GymClass
    {
        public int GymClassID { get; set; }
        [Required]
        [ForeignKey("Room")]
        public int RoomID { get; set; }
        public virtual Room Room { get; set; }
        [Required]
        [ForeignKey("Activity")]
        public int ActivityID { get; set; }
        public virtual Activity Activity { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        [DisplayName("Date and time")]
        public DateTime ClassDate { get; set; }
        [Required]
        [DisplayName("Duration in minutes")]
        public int DurationInMinutes { get; set; }
    }
}