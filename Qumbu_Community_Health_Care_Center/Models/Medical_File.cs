using Qumbu_Community_Health_Care_Center.Areas.Identity.Data;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Qumbu_Community_Health_Care_Center.Models
{
    public class Medical_File
    {
        [Key]
        public int fileId { get; set; }
        [Required]
        [Display(Name ="Patient")]
        public string? PatientID { get; set; }
        [ForeignKey("PatientID")]

        public ApplicationUser? PatientUser { get; set; }
        [Required]
        [Display(Name ="ID Number")]
        [MaxLength(13)]
        [MinLength(13)]
        public string? IDNumber { get; set; }

        [Required]
        [Display( Name="Date of Birth")]
        [DataType(DataType.Date)] 
        public DateTime? DateofBirth { get; set;}
        [Required]
        [Display(Name="Gender")]
        public string? Gender { get; set; }
        [Required]
        [Display(Name = "Address")]
        public string? Address { get; set; }

        [Display(Name ="Blood Type")]
        public string BloodType { get; set; }
        [Display(Name = "Allergies")]
        public string Allergies { get; set; }
        [Required]
        [Display(Name = "Next of kin full name")]
        public string NextfoKin { get; set; }


    }
}
