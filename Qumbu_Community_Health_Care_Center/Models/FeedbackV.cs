﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Collections.Generic;
using Qumbu_Community_Health_Care_Center.Areas.Identity.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace Qumbu_Community_Health_Care_Center.Models
{
    public class FeedbackV
    {
        [Key]
        public int FeedbackID { get; set; }

        //public string? PatientID { get; set; }
        //[ForeignKey("PatientID")]
        //public virtual ApplicationUser? Patient { get; set; }

        [Required]
        [DisplayName("First Name")]
        public string? Name { get; set; }

        [Required]
        [DisplayName("Last Name")]
        public string? Surname { get; set; }

        
        
        public int? rating { get; set; }

        
        //[DisplayName("Good")]
        //public int? rating2 { get; set; }

        
        //[DisplayName("Mediocre")]
        //public int? rating3 { get; set; }

      
        //[DisplayName("Bad")]
        //public int? rating4 { get; set; }

        
        //[DisplayName("Very Bad")]
        //public int? rating5 { get; set; }

        [Required]
        [DisplayName("Leave your comment here")]
        public string? Comment { get; set; }


    }
}
