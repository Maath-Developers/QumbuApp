using Qumbu_Community_Health_Care_Center.Areas.Identity.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Qumbu_Community_Health_Care_Center.Models
{
    public class Referrals
    {
        [Key]
        public int ReferralID { get; set; }
        public string?  PatientName { get; set; }
        public string? Departments { get; set; }
        public string? Remarks { get; set; }
        public String? PatientID { get; set; }
        [ForeignKey("PatientID")]
        public virtual ApplicationUser? MainUser { get; set; }
    }
}
