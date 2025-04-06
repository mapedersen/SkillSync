namespace API.Models.DTOs;

public class UserResponseDto
{
    public Guid Id { get; set; }
    public string Email { get; init; } = null!;
    public string Username { get; init; } = null!;
    public DateTime CreatedAt { get; set; }
    public ICollection<GoalResponseDto> Goals { get; init; } = [];
}