using API.Models;

namespace API.Repositories;

public interface IGoalRepository
{
    void Add(Goal goal);
    void Delete(Goal goal);
    Task<Goal?> GetByIdAsync(Guid goalId);
    Task<Goal?> GetByIdWithLogsAsync(Guid goalId);
    Task<List<Goal>> GetByUserIdAsync(Guid userId);

}
