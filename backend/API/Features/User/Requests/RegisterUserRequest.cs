using System.ComponentModel.DataAnnotations;

namespace API.Features.User.Requests;

public class RegisterUserRequest
{
    [Required]
    public string Username { get; set; } = null!;
    [Required]
    public string Email { get; set; } = null!;
    [Required]
    public string Password { get; set; } = null!;
}
