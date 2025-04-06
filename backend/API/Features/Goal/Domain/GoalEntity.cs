using API.Features.Log.Domain;
using API.Features.User.Domain;

namespace API.Features.Goal.Domain;

public class GoalEntity
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public required string Title { get; set; }
    public string? Description { get; set; }
    public string? Category { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public UserEntity? User { get; set; }
    public ICollection<LogEntity> Logs { get; set; } = [];

}
