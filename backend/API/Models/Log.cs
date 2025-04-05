namespace API.Models;

public class Log
{
    public Guid Id { get; set; }
    public Guid GoalId { get; set; }
    public required string Title { get; set; }
    public string? Note { get; set; }
    public required int DurationMinutes { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public required Goal Goal { get; set; }
}
