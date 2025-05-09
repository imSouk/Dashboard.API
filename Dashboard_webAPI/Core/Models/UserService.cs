using Dashboard_webAPI.Core.Dtos;
using Dashboard_webAPI.Core.Interfaces;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace Dashboard_webAPI.Core.Models;

public class UserService : IUserService
{
    private readonly IUserRepository _context;
    
    public UserService(UserRepository userRepository)
    {
        _context = userRepository;
        
    }
    public Task CreateUser(UserDto userDto)
    {
            User user = new  User(userDto);
            try
            {
                _context.AddUser(user);
                _context.SaveChangesAsync();
            }
            catch (Exception ex){Console.WriteLine(ex);}
        return Task.CompletedTask;
    }
    public async Task<string> LoginTask(UserDto userDto)
    {
        User missingUser = new User(userDto);
        try
        {
            string stats = string.Empty;
            User findedUser = await _context.FindByEmailAsync(missingUser.Email);
            if (_context.PasswordConfirm(findedUser) == missingUser.Password)
            {
                stats = "Autorized";
                return stats;
            }
            else {
                stats = "Rejected";
                return stats; }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return null;
        }
        
    }

    public async Task<Task> UpdateUser(UserDto userDto)
    {
        User user  = new  User(userDto);
        try
        {
             await _context.UpdateUser(user);
             await _context.SaveChangesAsync();
             return Task.CompletedTask;
        }
        catch (Exception ex) {
          Console.Write(ex);
          return Task.FromException<Exception>(ex);
        }
    }
    public Task DeleteUser(UserDto userDto)
    {
        User user = new  User(userDto);
        try
        {
            _context.DeleteUser(user);
            _context.SaveChangesAsync();
            return Task.CompletedTask;
        }
        catch (Exception e)
        {
            Console.WriteLine(e); 
            return Task.FromException<Exception>(e);
        }
        
    }
    public Task<List<UserDto>> GetAllUsers()
    {
        throw new NotImplementedException();
    }
    
}