using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Collections.Generic;

namespace Qumbu_Community_Health_Care_Center.Models
{
    public class FeedbackV
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [DisplayName("First Name")]
        public string? Name { get; set; }
        [Required]
        [DisplayName("Last Name")]
        public string? Surname { get; set; }
        [Required]
        [DisplayName("Very Good")]
        public string? rating1 { get; set; }
        [Required]
        [DisplayName("Good")]
        public string? rating2 { get; set; }
        [Required]
        [DisplayName("Mediocre")]
        public string? rating3 { get; set; }
        [Required]
        [DisplayName("Bad")]
        public string? rating4 { get; set; }
        [Required]
        [DisplayName("Very Bad")]
        public string? rating5 { get; set; }
        [Required]
        [DisplayName("Leave your comment here")]
        public string? Comment { get; set; }


    }
}
