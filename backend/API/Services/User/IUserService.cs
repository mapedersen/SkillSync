using API.Models.DTOs;

namespace API.Services;

public interface IUserService
{
    Task<UserResponseDto> RegisterAsync(RegisterUserDto dto);
    Task<UserResponseDto> LoginAsync(LoginDto dto);
    Task<UserResponseDto> GetUserByIdAsync(Guid id);
}
