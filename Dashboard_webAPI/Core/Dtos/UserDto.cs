using Dashboard_webAPI.Core.Models;

namespace Dashboard_webAPI.Core.Dtos;

public class UserDto 
{
    public UserDto()
    {
        
    }
    public UserDto(string email, string password)
    {
        this.Email = email;
        this.Password = password;
    }
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
    public User.UserRole Role { get; set; }
    
}