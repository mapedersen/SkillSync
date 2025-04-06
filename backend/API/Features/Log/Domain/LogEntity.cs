using API.Features.Goal.Domain;

namespace API.Features.Log.Domain;

public class LogEntity
{
    public Guid Id { get; set; }
    public Guid GoalId { get; set; }
    public required string Title { get; set; }
    public string? Note { get; set; }
    public required int DurationMinutes { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public required GoalEntity Goal { get; set; }
}
