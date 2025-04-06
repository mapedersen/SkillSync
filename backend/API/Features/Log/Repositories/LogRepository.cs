using API.Features.Log.Domain;
using API.Infra;
using Microsoft.EntityFrameworkCore;

namespace API.Features.Log.Repositories;

public class LogRepository : ILogRepository
{
    private readonly AppDbContext _context;
    public LogRepository(AppDbContext context)
    {
        _context = context;
    }
    public void Add(LogEntity log)
    {
        _context.Logs.Add(log);
    }

    public void Delete(LogEntity log)
    {
        _context.Logs.Remove(log);
    }

    public async Task<List<LogEntity>> GetByGoalIdAsync(Guid goalId)
    {
        return await _context.Logs.Where(x => x.GoalId == goalId).ToListAsync();
    }

    public async Task<LogEntity?> GetByIdAsync(Guid logId)
    {
        return await _context.Logs.FirstOrDefaultAsync(x => x.Id == logId);
    }
}
