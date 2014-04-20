using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace gymapp.Models
{
    public class Activity
    {
        public int ActivityID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [DisplayName("Calories per Hour")]
        public int CaloriesPerHour { get; set; }
    }

    public class GymAppDBContext : DbContext
    {
        public DbSet<Activity> Activities { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<GymClass> GymClasses { get; set; }
        public DbSet<MedicalHistory> MedicalHistores { get; set; }
    }
}