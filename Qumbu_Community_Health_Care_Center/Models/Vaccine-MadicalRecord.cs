using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Qumbu_Community_Health_Care_Center.Areas.Identity.Data;

namespace Qumbu_Community_Health_Care_Center.Models
{
	public class Vaccine_MadicalRecord
	{

		[Key]
		public int RecordID { get; set; }

		//      public int MedicalID { get; set; }
		//[ForeignKey("MedicalID")]
		//public virtual ApplicationUser? File { get; set; }

		[Required]
		[DisplayName("Blood Pressure")]
		public int? BloodPressure { get; set; }

		[Required]
		[DisplayName("Body Temperature ")]
		public int? Temperature { get; set; }

		[Required]
		[DisplayName("Heart Rate")]
		public int? HeartRate { get; set; }

		[Required]
		[DisplayName("Vaccine Date")]
		public DateTime? Date { get; set; } = DateTime.Now;

		[Required]
		[DisplayName("Weight (Kg)")]
		public int? Weight { get; set; }

        [Required]
        [DisplayName("Next Vaccination Date")]
        public DateTime? NextDate { get; set; } = DateTime.Now;

        [Required]
        [DisplayName(" Dose")]
        public string? dose { get; set; }

        //[Required]
        //[DisplayName("2nd Dose (Kg)")]
        //public string? dose2 { get; set; }

        //[Required]
        //[DisplayName("3rd Dose (Kg)")]
        //public string? dose3 { get; set; }

        public string? NurseID { get; set; }
		[ForeignKey("NurseID")]
		public virtual ApplicationUser? Nurse { get; set; }
	}
}
