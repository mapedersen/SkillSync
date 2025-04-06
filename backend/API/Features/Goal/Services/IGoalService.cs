using API.Features.Goal.Requests;
using API.Features.Goal.Responses;

namespace API.Features.Goal.Services;

public interface IGoalService
{
    Task<GoalResponse> CreateGoalAsync(CreateGoalRequest request, Guid userId);
    Task<List<GoalResponse>> GetGoalsByUserId(Guid userId);
    Task<GoalResponse?> GetGoalByIdAsync(Guid goalId);
    Task DeleteGoalAsync(Guid goalId, Guid userId);
}
