using System.ComponentModel.DataAnnotations;

namespace API.Models.DTOs.User;

public class RegisterUserDto
{
    [Required]
    public string Username { get; set; } = null!;
    [Required]
    public string Email { get; set; } = null!;
    [Required]
    public string Password { get; set; } = null!;
}