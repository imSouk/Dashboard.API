using Dashboard_webAPI.Core.Models;

namespace Dashboard_webAPI.Core.Dtos;

public class UserDto 
{
    public UserDto(User user)
    {  
            this.Name = user.Name;
            this.Email = user.Email;
    }
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
    public User.UserRole Role { get; set; }
    
}