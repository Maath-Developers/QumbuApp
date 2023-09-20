using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;
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
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime Date { get; set; }
        public string? Gender { get; set; }
        public string? CounsellingType { get; set; }
        public string? DOB { get; set; }
        public string? Status { get; set; }
        public string? Address { get; set; }
    }
}
