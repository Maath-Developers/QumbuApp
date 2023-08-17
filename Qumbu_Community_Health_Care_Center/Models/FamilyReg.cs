using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Qumbu_Community_Health_Care_Center.Models
{
    public class FamilyReg
    {
        [Key]
        public int FamilyRegId { get; set; }

        [Required]
        [DisplayName("When was the last time you enganged in sexual intercourse?")]
        public string? Description { get; set; }

        [Required]
        [DisplayName("When was the last time you had your periods?")]

        public string? Descriptions { get; set; }

        [Required]
        [DisplayName("Do you have a child?")]

        public string? expectection { get; set; }

        [Required]
        [DisplayName("Have experince any morning sickness?")]

        public string? experience { get; set; }

        [Required]
        [DisplayName("Choose any birth Control of your choice")]
        public string? type { get; set; }
    }
}
