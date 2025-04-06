
using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Repositories;

public class GoalRepository : IGoalRepository
{
    private readonly AppDbContext _context;

    public GoalRepository(AppDbContext context)
    {
        _context = context;
    }
    public void Add(Goal goal)
    {
        _context.Goals.Add(goal);
    }

    public void Delete(Goal goal)
    {
        _context.Goals.Remove(goal);
    }

    public async Task<Goal?> GetByIdAsync(Guid goalId)
    {
        return await _context.Goals.FirstOrDefaultAsync(g => g.Id == goalId);
    }

    public async Task<Goal?> GetByIdWithLogsAsync(Guid goalId)
    {
        return await _context.Goals.Include(g => g.Logs).FirstOrDefaultAsync(g => g.Id == goalId);
    }

    public async Task<List<Goal>> GetByUserIdAsync(Guid userId)
    {
        return await _context.Goals.Where(g => g.UserId == userId).ToListAsync();
    }
}
