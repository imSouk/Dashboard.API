using System.Web.Mvc;
using Dashboard_webAPI.Core.Dtos;
using Dashboard_webAPI.Core.Interfaces;
using Dashboard_webAPI.Services;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace Dashboard_webAPI.Core.Models;

public class UserService : IUserService
{
    private readonly IUserRepository _context;
    
    public UserService(IUserRepository userRepository )
    {
        _context = userRepository;
        
    }
    public async Task<User> CreateUser(UserDto userDto)
    {
        User user = User.RegisterDto(userDto);
            if (user == null)
            {
                throw new Exception("Error Creating User");
            }
            user.Password = BCrypt.Net.BCrypt.EnhancedHashPassword(userDto.Password, 13);
            await _context.AddUser(user);
            await _context.SaveChangesAsync();
        return user;
    }

    

    public async Task<string> LoginTask(LoginDto userDto)
    {   
        string stats = string.Empty;
        User missingUser = User.LoginDto(userDto);
        if (missingUser.Password == null && missingUser.Email == null)
        {
            throw new Exception("Invalid User");
        }
        User findedUser = await _context.FindByEmailAsync(missingUser.Email);
        string hashPassword = _context.PasswordConfirm(findedUser);
        if (BCrypt.Net.BCrypt.EnhancedVerify(missingUser.Password, findedUser.Password))
        { 
            stats = "Autorized";
            var token = TokenService.GerateToken(userDto);
            return token;
        }
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

    public async Task<User> DeleteUser(LoginDto userDto)
    {
        User basicUser = User.LoginDto(userDto);
        if (basicUser == null)
        {
            throw new Exception("Error Deleting User");
        }
        User completeUser = await _context.FindByEmailAsync(basicUser.Email);
        if (completeUser == null)
        {
            { throw new Exception("User not found");
            }
        }
        await _context.DeleteUser(completeUser);
        await _context.SaveChangesAsync();
        return completeUser;
       
    }
    public Task<List<UserDto>> GetAllUsers()
    {
        throw new NotImplementedException();
    }
}

    
