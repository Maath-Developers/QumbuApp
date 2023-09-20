﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Qumbu_Community_Health_Care_Center.Models
{
    public class PrenatalEducational
    {
        public int PrenatalEducationalID { get; set; }
        public string Title { get; set; }
        public DateTime PublishedDate { get; set; }
        public string Description { get; set; }
        public string ContentPdfUrl { get; set; }
        public string ImageUrl { get; set; } 
        public string Category { get; set; } 
        public int Views { get; set; } 
        public string FileName { get; set; }


        [DisplayName("Upload File")]
        [NotMapped]
        public IFormFile ImageFile { get; set; }
    }
}
