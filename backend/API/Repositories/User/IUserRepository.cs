using API.Models;

namespace API.Repositories.UserRepo;

public interface IUserRepository
{
    Task<User?> GetByIdWithGoalsAsync(Guid id);
    Task<bool> ExistsAsync(string email, string username);
    Task<User?> GetByUsernameAsync(string username);
    void Add(User user);
    void Delete(User user);
}
