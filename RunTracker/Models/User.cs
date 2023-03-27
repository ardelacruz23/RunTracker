using System.ComponentModel.DataAnnotations;

namespace RunTracker.Models
{
    public class User
    {
        public int UserId { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public TimestampAttribute LastLogin { get; set; }
        public string AvatarURL { get; set; }
        public string Salt { get; set; }
        [Required]
        public string PasswordHash { get; set; }

    }
}
