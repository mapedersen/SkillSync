using API.Features.Goal.Domain;
using API.Features.Goal.Mappers;
using API.Features.Goal.Repositories;
using API.Features.Goal.Requests;
using API.Features.Goal.Responses;
using API.Features.User.Repositories;
using API.Infra;

namespace API.Features.Goal.Services;

public class GoalService : IGoalService
{
    private readonly IGoalRepository _goalRepo;
    private readonly IUserRepository _userRepo;
    private readonly AppDbContext _context;
    public GoalService(IGoalRepository goalRepository, IUserRepository userRepository, AppDbContext context)
    {
        _goalRepo = goalRepository;
        _userRepo = userRepository;
        _context = context;
    }
    public async Task<GoalResponse> CreateGoalAsync(CreateGoalRequest request, Guid userId)
    {
        _ = await _userRepo.GetByIdAsync(userId) ?? throw new Exception("User not found");

        var goal = new GoalEntity
        {
            Id = Guid.NewGuid(),
            UserId = userId,
            Title = request.Title,
            Description = request.Description,
            Category = request.Category,
        };

        _goalRepo.Add(goal);

        await _context.SaveChangesAsync();

        return goal.ToResponse();
    }

    public async Task DeleteGoalAsync(Guid goalId, Guid userId)
    {
        _ = await _userRepo.GetByIdAsync(userId) ?? throw new Exception("User not found");

        var goal = await _goalRepo.GetByIdAsync(goalId);

        if (goal is not null)
            _goalRepo.Delete(goal);

        await _context.SaveChangesAsync();
    }

    public async Task<GoalResponse?> GetGoalByIdAsync(Guid goalId)
    {
        var goal = await _goalRepo.GetByIdAsync(goalId);

        if (goal is null)
            return null;

        var goalResponse = goal.ToResponse();

        return goalResponse;
    }

    public async Task<List<GoalResponse>> GetGoalsByUserId(Guid userId)
    {
        var goals = await _goalRepo.GetByUserIdAsync(userId);

        var goalsResponse = goals.ToResponseList();

        return goalsResponse;
    }
}
