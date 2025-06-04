using System.ComponentModel.DataAnnotations;
using Dashboard_webAPI.Core.Application.Dtos;
using Microsoft.EntityFrameworkCore;

namespace Dashboard_webAPI.Core.Domain.Models;

public class User
{
    public enum UserRole
    {
        Admin,
        Costumer,
    };
    public Guid Id { get; set; }
 
    [StringLength(15, MinimumLength = 2)]
    public string Name { get; set; }
    
    [StringLength(60, MinimumLength = 7)]
    public string? Password { get; set; }
    [EmailAddress]
    [StringLength(100, MinimumLength = 8)]
    public string? Email { get; set; }
    public UserRole Role { get; set; }
    public User()
    {

    }
    public static User LoginDto(LoginDto user) => new User
    {
 
        Password = user.Password,
        Email = user.Email,
    };
    public static User RegisterDto(UserDto user) => new User 
    {
        Id = Guid.NewGuid(),
        Name = user.Name,
        Password = user.Password,
        Email = user.Email,
        Role= UserRole.Costumer,
    };
    public User(string Email)
    {
        this.Email = Email;
    }

}