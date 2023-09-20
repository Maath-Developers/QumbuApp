using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Qumbu_Community_Health_Care_Center.Models
{
    public class FamilyReg
    {
        [Key]
        public int FamilyRegId { get; set; }

        [Required]
        [DisplayName("1.When was the last time you enganged in sexual intercourse?")]
        public string? intercourse { get; set; }

        [Required]
        [DisplayName("2.When was the last time you had your periods?")]

        public string? period { get; set; }

        [Required]
        [DisplayName("3.Do you have a child?")]

        public string? child { get; set; }

        [Required]
        [DisplayName("4.Have experince any morning sickness?")]

        public string? experience { get; set; }

        [Required]
        [DisplayName("5.do you have allergies?")]
        public string? allaegies { get; set; }

        [Required]
        [DisplayName("6.are you taking any medication?")]
        public string? medication { get; set; }

        [Required]
        [DisplayName("7.Have you ever used any contraceptives?")]
        public string? contraceptives { get; set; }


        [Required]
        [DisplayName("8.Choose any birth Control of your choice")]
        public string? type { get; set; }
    }
}
