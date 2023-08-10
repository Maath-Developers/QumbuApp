using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Qumbu_Community_Health_Care_Center.Models
{
    public class PatientReg
    {
        [Key]
        public int PatientRegId { get; set; }
        [Required]
        [DisplayName("FullNames")]
        public string? Names { get; set; }
        [Required]
        [DisplayName("D.O.B")]
        public string? DOB { get; set; }
        public string? Address { get; set; }
        public string? Cell { get; set; }
        public string ?Email { get; set; }
        [Required]
        [DisplayName("Names")]
        public string? KinName { get; set; }
        [Required]
        [DisplayName("Relationship to client: ")]
        public string? KinRel { get; set; }
        [Required]
        [DisplayName("Cell Number")]
        public string? KinCell { get; set; }
        [Required]
        [DisplayName("Referral Source")]
        public string? Source { get; set; }
        [Required]
        [DisplayName("Previous Counselling Experience")]
        public string? CounExperience { get; set; }
        [Required]
        [DisplayName("Medical & Mental Health")]
        public string? MedHealth { get; set; }
        [Required]
        [DisplayName("Current Medication")]
        public string? CurrentMed { get; set; }
        [Required]
        [DisplayName("Family History")]
        public string? FamHis { get; set; }
        [Required]
        [DisplayName("Preferred Communication & Consent")]
        public string? Comm { get; set; }
        [Required]
        [DisplayName("Current Stressors")]
        public string? CurrStress { get; set; }

    }
}
