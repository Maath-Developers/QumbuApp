using System.ComponentModel.DataAnnotations;

namespace Qumbu_Community_Health_Care_Center.Models
{
	public class Appointment
	{
		[Key]
		public int AppointmentId { get; set; }

		public string FirstName { get; set; }
		public string LastName { get; set; }
		public DateTime Date { get; set; }

		public TimeSpan? Time { get; set; }
		//public string? Notes { get; set; }
	}
}
