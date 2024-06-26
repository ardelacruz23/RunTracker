﻿using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace RunTracker.Models
{
    public class User
    {
        [Key]
        public int UserID { get; set; }
        [Required(ErrorMessage = "Please enter a valid email")]
        public string Email { get; set; } = String.Empty;
        [Required(ErrorMessage = "Please enter a valid first name")]
        public string FirstName { get; set; } = String.Empty;
        [Required(ErrorMessage = "Please enter a valid last name")]
        public string LastName { get; set; } = String.Empty;
        public DateTime LastLogin { get; set; } =  new DateTime();
        public string AvatarURL { get; set; } = String.Empty;
        [Required(ErrorMessage = "Please enter a valid password")]
        public string PasswordHash { get; set; } = String.Empty;

    }
}
