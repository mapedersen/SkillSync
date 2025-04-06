using API.Features.User.Requests;
using API.Features.User.Responses;

namespace API.Features.User.Services;

public interface IUserService
{
    Task<UserResponse> RegisterAsync(RegisterUserRequest request);
    Task<UserResponse> LoginAsync(LoginRequest request);
    Task<UserResponse> GetUserByIdAsync(Guid id);
}
