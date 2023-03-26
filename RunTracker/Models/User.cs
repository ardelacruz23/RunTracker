using System.ComponentModel.DataAnnotations;

namespace RunTracker.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public TimestampAttribute LastLogin { get; set; }
        public string AvatarURL { get; set; }
        public string Salt { get; set; }    
        public string PasswordHash { get; set; }

    }
}
