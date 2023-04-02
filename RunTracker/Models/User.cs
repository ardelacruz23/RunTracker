using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace RunTracker.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [Required(ErrorMessage = "Please enter a valid email")]
        public string Email { get; set; } = String.Empty;
        [Required(ErrorMessage = "Please enter a valid first name")]
        public string FirstName { get; set; } = String.Empty;
        public TimestampAttribute LastLogin { get; set; } = new TimestampAttribute();
        public string AvatarURL { get; set; } = String.Empty;
        [AllowNull] // CHANGE THIS TO REQUIRED AFTER TESTING
        public string Salt { get; set; }
        [Required(ErrorMessage = "Please enter a valid password")]
        public string PasswordHash { get; set; } = String.Empty;

    }
}
