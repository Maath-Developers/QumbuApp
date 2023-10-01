using Qumbu_Community_Health_Care_Center.Areas.Identity.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Qumbu_Community_Health_Care_Center.Models
{
    public class PrenatalArticle
    {
        [Key]
        public int Id { get; set; }
       
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime PublishDate { get; set; }
        public string Author { get; set; }
        public int PrenatalTopicId { get; set; }
        public PrenatalTopic PrenatalTopic { get; set; }
    }
}
