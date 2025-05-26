using Dashboard_webAPI.Core.Domain.Models;

namespace Dashboard_webAPI.Core.Application.Dtos;

public class UserDto 
{
    public UserDto()
    {
        
    }
    public UserDto(string email, string password)
    {
        Email = email;
        Password = password;
    }
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
    public User.UserRole Role { get; set; }
    
}