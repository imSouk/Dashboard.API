using System.ComponentModel.DataAnnotations;
using Dashboard_webAPI.Core.Dtos;

namespace Dashboard_webAPI.Core.Models;

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
        Id = user.Id,
        Name = user.Name,
        Password = user.Password,
        Email = user.Email,
        Role= user.Role,
    };
    public User(string Email)
    {
        this.Email = Email;
    }

}