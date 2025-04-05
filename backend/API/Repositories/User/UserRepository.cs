using System;
using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Repositories.UserRepo;

public class UserRepository : IUserRepository
{
    private readonly AppDbContext _context;
    public UserRepository(AppDbContext appDbContext)
    {
        _context = appDbContext;
    }
    public async Task<bool> ExistsAsync(string email, string username)
    {
        return await _context.Users.AnyAsync(u => u.Email == email || u.Username == username);
    }

    public async Task<User?> GetByIdWithGoalsAsync(Guid id)
    {
        return await _context.Users
            .Include(u => u.Goals)
                .ThenInclude(u => u.Logs)
            .FirstOrDefaultAsync(u => u.Id == id);
    }

    public async Task<User?> GetByUsernameAsync(string username)
    {
        return await _context.Users.FirstOrDefaultAsync(u => u.Username == username);
    }
}
