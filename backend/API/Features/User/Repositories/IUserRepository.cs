using API.Features.User.Domain;

namespace API.Features.User.Repositories;

public interface IUserRepository
{
    Task<UserEntity?> GetByIdWithGoalsAsync(Guid id);
    Task<UserEntity?> GetByIdAsync(Guid id);
    Task<bool> ExistsAsync(string email, string username);
    Task<UserEntity?> GetByUsernameAsync(string username);
    void Add(UserEntity user);
    void Delete(UserEntity user);
}
