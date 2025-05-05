using Dashboard_webAPI.Core.Models;

namespace Dashboard_webAPI.Core.Interfaces;

public interface IUserService
{
    Task<User> CreateUser(User user);
    Task<User> UpdateUser(User user);
    Task DeleteUser(User user);
    Task<List<User>> GetAllUsers();
    Task<User> GetUser(User user);
}