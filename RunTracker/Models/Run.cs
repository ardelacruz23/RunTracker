using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace RunTracker.Models
{
    public class Run
    {
        public int RunId { get; set; }
        public int UserId { get; set; }
        [Required]
        public string RunName { get; set; }
        public DateOnly RunDate { get; set; }
        [Required]
        public DateTime StartTime { get; set; }
        [Required]
        public DateTime EndTime { get; set; }
        [Required]
        public decimal Distance { get; set; }
        public TimeOnly Pace { get; set; }
        [AllowNull]
        public string PhotoURL { get; set; }
        [AllowNull]
        public string LocationName { get; set; }
        [AllowNull]
        public string City { get; set; }
        [AllowNull]
        public string State { get; set; }
        [AllowNull]
        public string Country { get; set; }
    }
}
