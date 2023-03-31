using System.ComponentModel.DataAnnotations;

namespace RunTracker.Models
{
    public class User
    {
        [Required (ErrorMessage = "Please enter a valid username.")]
        public int UserId { get; set; }
        [Required (ErrorMessage = "Please enter a valid email.")]
        public string Email { get; set; }
        [Required (ErrorMessage = "Please enter a valid first name.")]
        public string FirstName { get; set; }
		[Required(ErrorMessage = "Please enter a valid last name.")]
		public string LastName { get; set; }
        public TimestampAttribute LastLogin { get; set; }
        public string AvatarURL { get; set; }
        public string Salt { get; set; }
        [Required (ErrorMessage = "Please enter a valid password.")]
        public string PasswordHash { get; set; }

    }
}
