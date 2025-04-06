using API.Features.Log.Domain;

namespace API.Features.Log.Repositories;

public interface ILogRepository
{
    void Add(LogEntity log);
    void Delete(LogEntity log);
    Task<LogEntity?> GetByIdAsync(Guid logId);
    Task<List<LogEntity>> GetByGoalIdAsync(Guid goalId);

}

