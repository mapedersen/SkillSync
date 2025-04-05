using API.Models.DTOs.User;

namespace API.Services.User;

public interface IUserService
{
    Task<UserResponseDto> RegisterAsync(RegisterUserDto dto);
    Task<UserResponseDto> LoginAsync(LoginDto dto);
    Task<UserResponseDto> GetUserByIdAsync(Guid id);
}