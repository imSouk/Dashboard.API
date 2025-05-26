using Dashboard_webAPI.Core.Application.Dtos;
using Dashboard_webAPI.Core.Domain.Models;

namespace Dashboard_webAPI.Core.Interfaces;

public interface IUserService
{
    Task<User> CreateUser(UserDto user);
    Task<List<UserDto>> GetAllUsers();
    Task<List<string>> LoginTask(LoginDto user);
    public Task UpdateUser(UserDto user);
    Task<User> DeleteUser(LoginDto user);
  
    
}