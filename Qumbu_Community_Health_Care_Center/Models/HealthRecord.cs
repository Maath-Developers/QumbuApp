using Qumbu_Community_Health_Care_Center.Areas.Identity.Data;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Qumbu_Community_Health_Care_Center.Models
{
    public class HealthRecord
    {
        [Key]
        public int Id { get; set; }
        
        [DisplayName("Recorded Date")]
        public DateTime RecordedDate { get; set; }
        [Required]
        public double Weight { get; set; }
        public double Temperature { get; set; }
        public string? PatientID { get; set; }
        [ForeignKey("PatientID")]
        public virtual ApplicationUser? MainUser { get; set; }
        public string? PdfUrl { get; set; }
        [Required]
        [DisplayName("Blood Pressure Systolic")]
        public int BloodPressureSystolic { get; set; }
        [Required]
        [DisplayName("Blood Pressure Diastolic")]
        public int BloodPressureDiastolic { get; set; }
        [Required]
        public string? Symptoms { get; set; }
    }
}
