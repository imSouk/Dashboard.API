using Dashboard_webAPI.Core.Dtos;
using Dashboard_webAPI.Core.Models;

namespace Dashboard_webAPI.Core.Interfaces;

public interface IUserService
{
    Task<User> CreateUser(UserDto user);
    Task<List<UserDto>> GetAllUsers();
    Task<string> LoginTask(LoginDto user);
    public Task UpdateUser(UserDto user);
    Task DeleteUser(UserDto user);
  
    
}