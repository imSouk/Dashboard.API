using System.Web.Mvc;
using Dashboard_webAPI.Core.Dtos;
using Dashboard_webAPI.Core.Interfaces;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace Dashboard_webAPI.Core.Models;

public class UserService : IUserService
{
    private readonly IUserRepository _context;
    
    public UserService(IUserRepository userRepository)
    {
        _context = userRepository;
        
    }
    public Task CreateUser(UserDto userDto)
    {
        User user = User.RegisterDto(userDto);
            if (user == null)
            {
                throw new Exception("Error Creating User");
            }
            else 
            {
                user.Password = BCrypt.Net.BCrypt.EnhancedHashPassword(userDto.Password, 13);
            }
            _context.AddUser(user);
            _context.SaveChangesAsync();
            return Task.CompletedTask;
    }

    

    public async Task<string> LoginTask(UserDto userDto)
    {
        User missingUser = User.LoginDto(userDto);
        if (missingUser == null)
        {
            throw new Exception("Invalid User");
        }
        string stats;
        if (missingUser.Email != null)
        {
            User findedUser = await _context.FindByEmailAsync(missingUser.Email);
            string hashPassword = _context.PasswordConfirm(findedUser);
            if (BCrypt.Net.BCrypt.EnhancedVerify(missingUser.Password, findedUser.Password))
            {
                stats = "Autorized";
                return stats;
            }
        }
        stats = "Rejected";
        return stats;
    }

    public Task UpdateUser(UserDto userDto)
    {
        User user = User.RegisterDto(userDto);
        if (user == null)
        {
            throw new Exception("Error Updating User");
        }
        _context.UpdateUser(user);
        _context.SaveChangesAsync();
        return Task.CompletedTask;
    }

    public Task DeleteUser(UserDto userDto)
    {
        User user = User.RegisterDto(userDto);
        if (user == null)
        {
            throw new Exception("Error Deleting User");
        }
        _context.DeleteUser(user);
        _context.SaveChangesAsync();
        return Task.CompletedTask;
    }
    public Task<List<UserDto>> GetAllUsers()
    {
        throw new NotImplementedException();
    }
}

    
