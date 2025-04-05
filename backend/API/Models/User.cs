namespace API.Models;

public class User
{
    public Guid Id { get; set; }
    public required string Username { get; set; }
    public required string Email { get; set; }
    public required string passwordHash { get; set; }
    public DateTime CreatedAt { get; set; }
    public ICollection<Goal> Goals { get; set; } = [];
}
