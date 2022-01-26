﻿using System.ComponentModel.DataAnnotations;

namespace API.DTOs
{
    public class RegisterDto
    {
        [Required] public string DisplayName { get; set; }
        [Required] [EmailAddress] public string Email { get; set; }

        [Required]
        [RegularExpression(
            "(?=^.{6,10}$)(?=.*\\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[!@#$%^&amp;*()_+}{&quot;:;'?/&gt;.&lt;,])(?!.*\\s).*$",
            ErrorMessage =
                "Password must be at least 6 characters long, and must contain at least 1 Uppercase, 1 Lowercase, 1 Number, 1 special sign")]
        public string Password { get; set; }
    }
}