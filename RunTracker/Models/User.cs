using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace RunTracker.Models
{
    public class User
    {
        
        public int UserId { get; set; }
        [AllowNull]
        // [Required(ErrorMessage ="Please enter a valid email")]
        public string Email { get; set; }
        [AllowNull]
        // [Required(ErrorMessage ="Please enter a valid first name")]
        public string FirstName { get; set; }
        [AllowNull]
        public TimestampAttribute LastLogin { get; set; }
        [AllowNull]
        public string AvatarURL { get; set; }
         [AllowNull] // CHANGE THIS TO REQUIRED AFTER TESTING
        public string Salt { get; set; }
        // [Required(ErrorMessage ="Please enter a valid password")]
        [AllowNull]
        public string PasswordHash { get; set; }

    }
}
