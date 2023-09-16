using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Qumbu_Community_Health_Care_Center.Models
{
    public class UltrasoundAppointment
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Full Name")]
        public string UserId { get; set; }
        [Required]
        [DisplayName("Appointment Date")]
        public DateTime AppointmentDate { get; set; }
        [Required]
        [DisplayName("Gestational Age Weeks")]
        public int GestationalAgeWeeks { get; set; }
        [Required]
        [DisplayName("Fetal Heart Rate")]
        public string FetalHeartRate { get; set; }
        public string Observations { get; set; }
        [DisplayName("Gender Determined")]
        public bool GenderDetermined { get; set; }
        [Required]
        public string Comments { get; set; }
        [Required]
        [DisplayName("Fetal Image")]
        public string UltrasoundImagePath { get; set; }
        public string FileName { get; set; }

        [NotMapped]
        [DisplayName("Upload File")]
        public IFormFile ImageFile { get; set; }
    }
}
