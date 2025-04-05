namespace API.Models;

public class User
{
    public Guid Id { get; private set; }
    public string Username { get; private set; } = null!;
    public string Email { get; private set; } = null!;
    public string PasswordHash { get; private set; } = null!;
    public DateTime CreatedAt { get; private set; } = DateTime.UtcNow;
    public ICollection<Goal> Goals { get; set; } = [];

    private User() { }

    public User(string username, string email, string passwordHash)
    {
        Username = username;
        Email = email;
        PasswordHash = passwordHash;
    }
}
