﻿using System.ComponentModel.DataAnnotations;

namespace API.Features.User.Responses;

public class LoginRequest
{
    [Required]
    public string Username { get; set; } = null!;
    [Required]
    public string Password { get; set; } = null!;
}
