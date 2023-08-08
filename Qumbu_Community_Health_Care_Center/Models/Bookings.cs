namespace Qumbu_Community_Health_Care_Center.Models
{
    public class Bookings
    {
        public int BookingId { get; set; }
        public string? Name { get; set; }
        public DateTime Date { get; set; }
        public TimeZone? Time { get; set; }
    }
}
