using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Collections.Generic;

namespace Qumbu_Community_Health_Care_Center.Models
{
    public class ScreeningTool
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string? FirstName { get; set; }
        [Required]
        public int LastName { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public string Gender { get; set; }
        public List<string> Symptoms { get; set; }

        public bool IsHighRisk { get; set; }    

        public ScreeningTool()
        {
            Symptoms = new List<string>();
        }

        public void CalculateRisk()
        {
            IsHighRisk = (Age > 60) || (Symptoms.Contains("Fever") && Symptoms.Contains("Cough"));
        }

       
    }
}
