namespace Queue_Management_System.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string ServiceType { get; set; }
        public string TicketNumber { get; set; }
        public DateTime CheckInTime { get; set; }
        public DateTime? CalledTime { get; set; }
        public DateTime? FinishedTime { get; set; }
        public string Status { get; set; }
    }
}
