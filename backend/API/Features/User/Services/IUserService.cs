using API.Features.User.Requests;
using API.Features.User.Responses;

namespace API.Features.User.Services;

public interface IUserService
{
    Task<UserResponse> RegisterAsync(RegisterUserDto dto);
    Task<UserResponse> LoginAsync(LoginRequest dto);
    Task<UserResponse> GetUserByIdAsync(Guid id);
}
