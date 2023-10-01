
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Qumbu_Community_Health_Care_Center.Models
{
    public class PrenatalEducation
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public DateTime PublishDate { get; set; }
        public string Author { get; set; }
        public string CoverImagePath { get; set; }
        //public IFormFile ContentPdf { get; set; }
        public string FileName { get; set; }
        [NotMapped]
        public IFormFile CoverImage { get; set; }
        

    }
}
