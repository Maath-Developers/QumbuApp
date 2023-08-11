using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Qumbu_Community_Health_Care_Center.Models
{
	public class Feedbacks
	{
		[Key]
		public int FeedbackId { get; set; }

		[Required]
		public string? Name { get; set; }
		[Required]
		public string? Surname { get; set; }
		[Required]
		[DisplayName("Side effects")]
		public string? experienced { get; set; }
		[Required]
		[DisplayName("Message")]
		public string? Description { get; set; }

	}
}
