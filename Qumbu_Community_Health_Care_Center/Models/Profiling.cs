using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Qumbu_Community_Health_Care_Center.Models
{
    public class Profiling
    {
        [Key]
        public int ProfileID { get; set; }
        public string? ID { get; set; }
        public string? email { get; set; }
        public string? Cell { get; set; }
        [DisplayName("First Name")]
        public string? FirstName { get; set; }
        [DisplayName("Last Name")]
        public string? LastName { get; set; }
        public DateTime Date { get; set; }
        [DisplayName("Visit Purpose")]
        public string? VisitPurpose { get; set; }
        public string? Gender { get; set; }
        [DisplayName("Counselling Type")]
        public string? CounsellingType { get; set; }
        [DisplayName("Counselling Approach")]
        public string? CounsellingApproach { get; set; }
        public string? GroupName { get; set; }
        public string? DOB { get; set; }
        public string? Status { get; set; }
        public string? Background { get; set; }
        public string? Address { get; set; }
        [DisplayName("Counselling Goals")]
        public string? Goals { get; set; }
        [DisplayName("Comments")]
        public string? comments { get; set; }
        [DisplayName("Recommendations")]
        public string? recom { get; set; }
    }
}
