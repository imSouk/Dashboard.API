using Dashboard_webAPI.Core.Models;

namespace Dashboard_webAPI.Core.Interfaces
{
    public interface IUserRepository
    {
        Task AddUser(User user);
        Task<User> FindByIdAsync(int id);
        Task<User> FindByNameAsync(string name);
        Task<User> FindByEmailAsync(string email);
        Task UpdateUser(User user);
        Task DeleteUser(User user);
        Task SaveChangesAsync();
    }
}
