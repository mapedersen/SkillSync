using API.Features.Goal.Responses;

namespace API.Features.User.Responses;

public class UserResponse
{
    public Guid Id { get; set; }
    public string Email { get; init; } = null!;
    public string Username { get; init; } = null!;
    public DateTime CreatedAt { get; set; }
    public ICollection<GoalResponse> Goals { get; init; } = [];
}
