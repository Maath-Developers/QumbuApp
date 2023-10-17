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
        [DisplayName("Appointment Date")]
        public DateTime AppointmentDate { get; set; }
        [Required]
        [DisplayName("Gestational Age Weeks")]
        public DateTime GestationalAgeWeeks { get; set; }
        [Required]
        [DisplayName("Fetal Heart Rate")]
        public string FetalHeartRate { get; set; }
        [Required]
        public string Observations { get; set; }
        [DisplayName("Gender Determined")]
        public string GenderDetermined { get; set; }
        [Required]
        public string Comments { get; set; }
        [Required]
        [DisplayName("Fetal Image")]
        public string UltrasoundImagePath { get; set; }
        [NotMapped]
        [DisplayName("Upload Image")]
        public IFormFile ImageFile { get; set; }
    }
}
