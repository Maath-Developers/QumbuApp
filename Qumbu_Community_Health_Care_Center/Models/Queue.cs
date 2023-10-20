using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Qumbu_Community_Health_Care_Center.Models
{
	public class Queue
	{
		[Key]
		public int QueID { get; set; }
		public int? AppointmentID { get; set; }
		[ForeignKey(nameof(AppointmentID))]
		[DataType(DataType.Time)]
		public DateTime Delay { get; set; }
		public virtual Appointment? Appointment { get; set; }
		public string? Status { get; set; }
	}
}
