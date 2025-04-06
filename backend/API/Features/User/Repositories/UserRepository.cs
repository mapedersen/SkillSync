using API.Features.User.Domain;
using API.Infra;
using Microsoft.EntityFrameworkCore;

namespace API.Features.User.Repositories;

public class UserRepository : IUserRepository
{
    private readonly AppDbContext _context;
    public UserRepository(AppDbContext appDbContext)
    {
        _context = appDbContext;
    }

    public void Add(UserEntity user)
    {
        _context.Users.Add(user);
    }

    public void Delete(UserEntity user)
    {
        _context.Remove(user);
    }

    public async Task<bool> ExistsAsync(string email, string username)
    {
        return await _context.Users.AnyAsync(u => u.Email == email || u.Username == username);
    }

    public async Task<UserEntity?> GetByIdWithGoalsAsync(Guid id)
    {
        return await _context.Users
            .Include(u => u.Goals)
                .ThenInclude(u => u.Logs)
            .FirstOrDefaultAsync(u => u.Id == id);
    }

    public async Task<UserEntity?> GetByUsernameAsync(string username)
    {
        return await _context.Users.FirstOrDefaultAsync(u => u.Username == username);
    }
}
