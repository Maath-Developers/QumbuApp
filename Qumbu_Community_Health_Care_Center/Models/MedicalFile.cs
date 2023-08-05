using Qumbu_Community_Health_Care_Center.Areas.Identity.Data;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Qumbu_Community_Health_Care_Center.Models
{
    public class MedicalFile
    {
        [Key]
        public int MedicalID { get; set; }

        [ForeignKey("Id")]
        public string? Id { get; set; }
        public virtual ApplicationUser? User { get; set; }


        [Required]
        [DisplayName("Identity Number")]
        public int IDno { get; set; }

        [Required]
        [DisplayName("Date of Birth")]
        public DateTime? DateOfBirth { get; set; }

        [Required]
        public string? Gender { get; set; }

        public string? Address { get; set; }


        public string? City { get; set; }
        [DisplayName("Patient Diagnosis")]
        public string PatientDiagnosis { get; set; }

        [DisplayName("Marital Stataus")]
        public string MaritalStatus { get; set; }
        public string Nationality { get; set; }

        [Required]
        public string Laguage { get; set; }


    }
}
