﻿using Dashboard_webAPI.Core.Domain.Models;
using Dashboard_webAPI.Core.Interfaces;
using Dashboard_webAPI.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Dashboard_webAPI.Infrastructure
{
    public class UserRepository : IUserRepository
    {
        private readonly DashboardContext _context;
        public UserRepository(DashboardContext context)
        {
            _context = context;
        }
        public async Task AddUser(User user) => await _context.Users.AddAsync(user);
        public async Task<User> FindByIdAsync(Guid id)
        {
            var userFinder = await _context.Users.FindAsync(id);
            return userFinder;
        }
        public async Task<User> FindByNameAsync(string name)
        {
            var userFinder = await _context.Users.FirstOrDefaultAsync(userFinder => userFinder.Name == name);
            return userFinder;
        }
        public async Task<User> FindByEmailAsync(string email)
        {
            var userFinder = await _context.Users.FirstOrDefaultAsync(userFinder => userFinder.Email == email);
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

        public string PasswordConfirm(User user)
        {
           string confirmPassword =  _context.Users.Select(user => user.Password).Where(e => e == user.Email).ToString();
           return  confirmPassword;
        }
        public async Task SaveChangesAsync() => await _context.SaveChangesAsync();
    }
}
