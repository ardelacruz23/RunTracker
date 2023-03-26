namespace RunTracker.Models
{
    public class Run
    {
        public int RunId { get; set; }
        public int UserId { get; set; }
        public string RunName { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public decimal Distance { get; set; }
        public TimeOnly Pace { get; set; }
        public string PhotoURL { get; set; }
        public string LocationName { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
    }
}
