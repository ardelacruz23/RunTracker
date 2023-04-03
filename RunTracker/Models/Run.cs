using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace RunTracker.Models
{
    public class Run
    {
        [Key]
        public int RunId { get; set; }
        [Required]
        public int UserId { get; set; }
        [Required (ErrorMessage="Please enter a name for the run")]
        public string RunName { get; set; } = string.Empty;
        [Required (ErrorMessage ="Please Enter a valid Date")]
        [DisplayName("Run Date")]
        public DateOnly RunDate { get; set; }
        [Required]
        public TimeOnly StartTime { get; set; }
        [Required]
        public TimeOnly EndTime { get; set; }
        [Required]
        public decimal Distance { get; set; }
        // [Required] --> Set this to Required AFTER implementing the function to compute and store run Pace
        public decimal Pace { get; set; }

        public string PhotoURL { get; set; } = String.Empty;

        public string LocationName { get; set; } = String.Empty;
      
        public string City { get; set; } = String.Empty;

        public string State { get; set; } = String.Empty;

        public string Country { get; set; } = String.Empty;
    }
}
