using API.Features.Goal.Domain;
using API.Infra;
using Microsoft.EntityFrameworkCore;

namespace API.Features.Goal.Repositories;

public class GoalRepository : IGoalRepository
{
    private readonly AppDbContext _context;

    public GoalRepository(AppDbContext context)
    {
        _context = context;
    }
    public void Add(GoalEntity goal)
    {
        _context.Goals.Add(goal);
    }

    public void Delete(GoalEntity goal)
    {
        _context.Goals.Remove(goal);
    }

    public async Task<GoalEntity?> GetByIdAsync(Guid goalId)
    {
        return await _context.Goals.FirstOrDefaultAsync(g => g.Id == goalId);
    }

    public async Task<GoalEntity?> GetByIdWithLogsAsync(Guid goalId)
    {
        return await _context.Goals.Include(g => g.Logs).FirstOrDefaultAsync(g => g.Id == goalId);
    }

    public async Task<List<GoalEntity>> GetByUserIdAsync(Guid userId)
    {
        return await _context.Goals.Where(g => g.UserId == userId).ToListAsync();
    }
}
