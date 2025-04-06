using API.Features.Goal.Domain;

namespace API.Features.User.Domain;

public class UserEntity
{
    public Guid Id { get; private set; }
    public string Username { get; private set; } = null!;
    public string Email { get; private set; } = null!;
    public string PasswordHash { get; private set; } = null!;
    public DateTime CreatedAt { get; private set; } = DateTime.UtcNow;
    public ICollection<GoalEntity> Goals { get; set; } = [];

    private UserEntity() { }

    public UserEntity(string username, string email, string passwordHash)
    {
        Username = username;
        Email = email;
        PasswordHash = passwordHash;
    }
}
