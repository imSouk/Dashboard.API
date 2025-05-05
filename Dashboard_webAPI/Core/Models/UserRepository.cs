using Dashboard_webAPI.Core.Interfaces;
using Dashboard_webAPI.Models;

namespace Dashboard_webAPI.Core.Models
{
    public class UserRepository : IUserRepository
    {
        private readonly DashboardContext _context;
        public UserRepository(DashboardContext context)
        {
            _context = context;
        }
        public async Task AddUser(User user) => await _context.Users.AddAsync(user);
        public async Task<User> FindByIdAsync(int id)
        {
            var userFinder = await _context.Users.FindAsync(id);
            return userFinder;
        }
        public async Task<User> FindByNameAsync(string name)
        {
            var userFinder = await _context.Users.FindAsync(name);
            return userFinder;
        }
        public async Task<User> FindByEmailAsync(string email)
        {
            var userFinder = await _context.Users.FindAsync(email);
            return userFinder;
        }
        public Task UpdateUser(User user)
        {
            _context.Users.Update(user);
            return Task.CompletedTask;
        }
        public Task DeleteUser(User user)
        {
            _context.Users.Remove(user);  
            return Task.CompletedTask;
        }
        public Task SaveChangesAsync() => _context.SaveChangesAsync();
    }
}
