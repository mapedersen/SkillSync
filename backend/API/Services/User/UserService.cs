using API.Models.DTOs;

namespace API.Services;

public class UserService : IUserService
{
    public Task<UserResponseDto> GetUserByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<UserResponseDto> LoginAsync(LoginDto dto)
    {
        throw new NotImplementedException();
    }

    public Task<UserResponseDto> RegisterAsync(RegisterUserDto dto)
    {
        throw new NotImplementedException();
    }
}
