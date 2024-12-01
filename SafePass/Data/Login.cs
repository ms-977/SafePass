﻿using System.ComponentModel.DataAnnotations;

namespace SafePass.Data
{
     public class Login
     {
          [Key]
          public Guid Id { get; set; }

          [Required(ErrorMessage = "Name is required and cannot be empty.")]
          [StringLength(50, ErrorMessage = "Name cannot exceed 50 characters.")]
          public string? Name { get; set; }

          [Required(ErrorMessage = "Username is required and cannot be empty.")]
          public string? Username { get; set; }

          [Required(ErrorMessage = "Password is required and cannot be empty.")]
          [StringLength(50, ErrorMessage = "Password cannot exceed 50 characters.")]
          [MinLength(12, ErrorMessage = "Password must be at least 12 characters long.")]
          public string? Password { get; set; }

          [Required(ErrorMessage = "URL is required and cannot be empty.")]
          [Url(ErrorMessage = "Please enter a valid URL.")]
          public string? URL { get; set; }
     }
}
