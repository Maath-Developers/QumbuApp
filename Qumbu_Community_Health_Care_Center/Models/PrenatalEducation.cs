
using System.ComponentModel;
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

        [DisplayName("Publish date")]
        public DateTime PublishDate { get; set; }
        public string Author { get; set; }
        public string ImageUrl { get; set; }
        public string PdfUrl { get; set; }
        public string ImageName { get; set; }
        public string PdfName { get; set; }
        [DisplayName(" Choose the cover Image of content")]
        [NotMapped]
        public IFormFile CoverImage { get; set; }
        [DisplayName("Upload your content in pdf format")]
        [NotMapped]
        public IFormFile ContentPdf { get; set; }


    }
}
