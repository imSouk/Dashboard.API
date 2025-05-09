using Dashboard_webAPI.Core.Dtos;
using Dashboard_webAPI.Core.Models;

namespace Dashboard_webAPI.Core.Interfaces;

public interface IUserService
{
    Task CreateUser(UserDto user);
    Task UpdateUser(UserDto user);
    Task DeleteUser(UserDto user);
    Task<List<UserDto>> GetAllUsers();
    Task<UserDto> GetUser(UserDto user);
}