
using Qumbu_Community_Health_Care_Center.Areas.Identity.Data;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Qumbu_Community_Health_Care_Center.Models
{
    public class PrenatalEducation
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string? Title { get; set; }
        [Required]
        public string? Description { get; set; }
        [Required]
        public string? Category { get; set; }
        [DisplayName("Publish date")]
        [Required]
        public DateTime PublishDate { get; set; } 
        public string? Author { get; set; }
        [Required]
        public string? ImageUrl { get; set; }
        public string? NurseID { get; set; }
        [ForeignKey("PatientID")]
        public virtual ApplicationUser? MainUser { get; set; }
        [Required]
        public string? PdfUrl { get; set; }
        [DisplayName("Choose the cover image of content")]
        [NotMapped]
        public IFormFile? CoverImage { get; set; }
        [DisplayName("Upload your content in pdf format")]
        [NotMapped]
        public IFormFile? ContentPdf { get; set; }
       
    }
}
