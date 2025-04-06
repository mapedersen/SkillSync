using API.Features.User.Requests;
using API.Features.User.Responses;

namespace API.Features.User.Services;

public class UserService : IUserService
{
    public Task<UserResponse> GetUserByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<UserResponse> LoginAsync(LoginRequest dto)
    {
        throw new NotImplementedException();
    }

    public Task<UserResponse> RegisterAsync(RegisterUserDto dto)
    {
        throw new NotImplementedException();
    }
}
