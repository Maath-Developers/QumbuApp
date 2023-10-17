using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Collections.Generic;
using Qumbu_Community_Health_Care_Center.Areas.Identity.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace Qumbu_Community_Health_Care_Center.Models
{
    public class ScreeningTool
    {
		[Key]
		public int ScreeningID { get; set; }

		public string? PatientID { get; set; }
		[ForeignKey("PatientID")]
		public virtual ApplicationUser? Patient { get; set; }


		[Required]
		[DisplayName("1) Do you have any allergies ?")]
		public string? Question1 { get; set; }
		[Required]
		[DisplayName("2) Are you pregnant? ?")]
		public string? Question2 { get; set; }
		[Required]
		[DisplayName("3) Are you sick today ?")]
		public int Question3 { get; set; }
		[Required]
		[DisplayName("4) Are you coughing")]
		public string? Question4 { get; set; }
		[Required]
		[DisplayName("5) Do you have shortness of breath or difficulty in breathing ?")]
		public string? Question5 { get; set; }
		[Required]
		[DisplayName("6) Do you have headache ?")]
		public string? Question6 { get; set; }
		//public List<string> Symptoms { get; set; }

		//public bool IsHighRisk { get; set; }

		//public ScreeningTool()
		//{
		//    Symptoms = new List<string>();
		//}

		//public void CalculateRisk()
		//{
		//    IsHighRisk = (Age > 60) || (Symptoms.Contains("Fever") && Symptoms.Contains("Cough"));
		//}


	}
}
