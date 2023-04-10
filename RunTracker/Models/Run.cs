using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace RunTracker.Models
{
    public class Run
    {
        [Key]
        public int RunID { get; set; }
        [Required(ErrorMessage = "Please enter a name for the run")]
        public string RunName { get; set; } = string.Empty;
        [Required(ErrorMessage = "Please enter a valid Date")]
        [DisplayName("Run Date")]
        public string RunDate { get; set; } = String.Empty;
        [Required(ErrorMessage = "Please enter a Start Time")]
        public string StartTime { get; set; } = String.Empty;
        [Required(ErrorMessage = "Please enter an End Time")]
        public string EndTime { get; set; } = String.Empty;
        [Required(ErrorMessage = "Please enter a valid Distance")]
        public decimal Distance { get; set; }       
        public string? Measurement { get; set; }
        public string? Duration { get; set; }
        public string? Pace { get; set; }
        public string? PhotoURL { get; set; }
        public string? LocationName { get; set; }

        public string? City { get; set; }

        public string? State { get; set; }

        public string? Country { get; set; }

    }
}
