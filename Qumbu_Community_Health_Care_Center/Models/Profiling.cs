﻿using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;
using Qumbu_Community_Health_Care_Center.Areas.Identity.Data;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Qumbu_Community_Health_Care_Center.Models
{
    public class Profiling
    {
        [Key]
        public int ProfileID { get; set; }
        //public string? ID { get; set; }
        //public string? Id { get; set; }
        //[ForeignKey("Id")]
        //public virtual ApplicationUser? User { get; set; }
        //public string? email { get; set; }
        //public string? Cell { get; set; }
        [DisplayName("First Name")]
        public string? AppointmentID { get; set; }
        [ForeignKey("AppointmentID")]
        [Required]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; } = DateTime.Now; 
        [DataType(DataType.Time)]
		public DateTime Time { get; set; } = DateTime.Now;
		[DisplayName("Visit Purpose")]
        public string? VisitPurpose { get; set; }
        //public string? Gender { get; set; }
        [DisplayName("Counselling Type:")]
        public string? CounsellingType { get; set; }
        [DisplayName("(a).Counselling Approach:")]
        public string? CounsellingApproach { get; set; }
        //public string? GroupName { get; set; }
        //public string? DOB { get; set; }
        public string? Status { get; set; }
        [DisplayName("I.Background of the Case:")]
        public string? Background { get; set; }
        [DisplayName("II.Counselling Plan:")]
        public string? CounsellingPlan { get; set; }
        public string? Address { get; set; }
        [DisplayName("(b).Counselling Goals:")]
        public string? Goals { get; set; }
        [DisplayName("III.Comments:")]
        public string? comments { get; set; }
        [DisplayName("IV.Recommendations:")]
        public string? recom { get; set; }
        public String? PatientID { get; set; }
        [ForeignKey("PatientID")]
        public virtual ApplicationUser? MainUser { get; set; }

    }
}
