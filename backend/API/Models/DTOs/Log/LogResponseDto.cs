namespace API.Models.DTOs.Log;
public class LogResponseDto
{
    public Guid Id { get; init; }
    public string Title { get; init; } = null!;
    public string? Note { get; init; }
    public int DurationMinutes { get; init; }
    public DateTime CreatedAt { get; init; }
}
