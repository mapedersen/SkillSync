using API.Features.Goal.Domain;

namespace API.Features.Goal.Repositories;

public interface IGoalRepository
{
    void Add(GoalEntity goal);
    void Delete(GoalEntity goal);
    Task<GoalEntity?> GetByIdAsync(Guid goalId);
    Task<GoalEntity?> GetByIdWithLogsAsync(Guid goalId);
    Task<List<GoalEntity>> GetByUserIdAsync(Guid userId);

}
