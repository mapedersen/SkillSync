
using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Repositories;

public class LogRepository : ILogRepository
{
    private readonly AppDbContext _context;
    public LogRepository(AppDbContext context)
    {
        _context = context;
    }
    public void Add(Log log)
    {
        _context.Logs.Add(log);
    }

    public void Delete(Log log)
    {
        _context.Logs.Remove(log);
    }

    public async Task<List<Log>> GetByGoalIdAsync(Guid goalId)
    {
        return await _context.Logs.Where(x => x.GoalId == goalId).ToListAsync();
    }

    public async Task<Log?> GetByIdAsync(Guid logId)
    {
        return await _context.Logs.FirstOrDefaultAsync(x => x.Id == logId);
    }
}
