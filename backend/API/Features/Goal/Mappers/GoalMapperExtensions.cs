using API.Features.Goal.Domain;
using API.Features.Goal.Responses;

namespace API.Features.Goal.Mappers;

public static class GoalMapperExtensions
{
    public static GoalResponse ToResponse(this GoalEntity goal) => new()
    {
        Id = goal.Id,
        Title = goal.Title,
        Description = goal.Description,
        Category = goal.Category,
        CreatedAt = goal.CreatedAt
    };

    public static List<GoalResponse> ToResponseList(this List<GoalEntity> goals)
    {
        return goals.Select(g => g.ToResponse()).ToList();
    }
}
