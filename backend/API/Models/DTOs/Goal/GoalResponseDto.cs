namespace API.Models.DTOs;

public class GoalResponseDto
{
    public Guid Id { get; init; }
    public string Title { get; init; } = null!;
    public string? Description { get; init; }
    public string? Category { get; init; }
    public DateTime CreatedAt { get; init; }
}
