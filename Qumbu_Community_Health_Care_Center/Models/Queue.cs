using Qumbu_Community_Health_Care_Center.Areas.Identity.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Qumbu_Community_Health_Care_Center.Models
{
	public class Queue
	{
		[Key]
		public int QueID { get; set; }

		public string? PatientID { get; set; }
		[ForeignKey("PatientID")]
		[DataType(DataType.Time)]
		public DateTime Delay { get; set; }
        public virtual ApplicationUser? MainUser { get; set; }
       
		public string? Condition { get; set; }
        

    }
}
