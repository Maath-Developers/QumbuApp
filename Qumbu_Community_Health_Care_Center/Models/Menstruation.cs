using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Qumbu_Community_Health_Care_Center.Models
{
    public class Menstruation
    {

        [Key]
        public int MenstruationId { get; set; }
        [Required]
        [Display(Name = "Appointment Day")]
        [DataType(DataType.DateTime)]
        public DateTime Date { get; set; }

        [Required]
        [Display(Name = "Appointment Day")]
        [DataType(DataType.DateTime)]
        public DateTime EndDate { get; set; }
        public string? Departments { get; set; }
        
       
    }
}
