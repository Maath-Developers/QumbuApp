
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Qumbu_Community_Health_Care_Center.Models
{
    public class PrenatalCareEducation
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string ContentUrl { get; set; }
        [NotMapped]
        public IFormFile ContentPdf { get; set; }
        public DateTime PublishedDate { get; set; }
        public string Author { get; set; }  
        public string ImageUrl { get; set; }
        [NotMapped]
        public IFormFile Image { get; set; }
        public string Category { get; set; }
        
    }
}
