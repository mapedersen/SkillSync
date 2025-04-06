using API.Models;

namespace API.Repositories;

public interface ILogRepository
{
    void Add(Log log);
    void Delete(Log log);
    Task<Log?> GetByIdAsync(Guid logId);
    Task<List<Log>> GetByGoalIdAsync(Guid goalId);

}

