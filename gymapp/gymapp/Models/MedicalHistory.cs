using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace gymapp.Models
{
    public class MedicalHistory
    {
        public int MedicalHistoryID { get; set; }
        [Required]
        [DisplayName("Hospitalised in the past 6 months")]
        public bool RecentlyHospitalized { get; set; }
        [Required]
        [DisplayName("High blood pressure")]
        public bool HighBloodPressure { get; set; }
        [Required]
        [DisplayName("High cholesterol level")]
        public bool HighCholesterol { get; set; }
        [Required]
        public bool Diabetes { get; set; }
        [Required]
        [DisplayName("Heart attack or stroke")]
        public bool HeartAttackOrStroke { get; set; }
        [Required]
        [DisplayName("Heart condition")]
        public bool HeartConditions { get; set; }
        [Required]
        [DisplayName("Back problems")]
        public bool BackProblems { get; set; }
        [DisplayName("Alergies. Please specify")]
        public string Allergies { get; set; }
        [DisplayName("Medication. Please specify")]
        public string Medication { get; set; }
        [DisplayName("Chronic ilnesses. Please specify")]
        public string ChronicIlnesses { get; set; }
        [DisplayName("Other information")]
        public string Other { get; set; }

    }
}