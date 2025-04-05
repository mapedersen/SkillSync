namespace API.Models;

public class Goal
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public required string Title { get; set; }
    public string? Description { get; set; }
    public string? Category { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public required User User { get; set; }
    public ICollection<Log> Logs { get; set; } = [];

}
