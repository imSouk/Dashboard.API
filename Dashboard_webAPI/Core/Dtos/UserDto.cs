using Dashboard_webAPI.Core.Models;

namespace Dashboard_webAPI.Core.Dtos;

public class UserDto 
{
    public UserDto(User user)
    {
            this.Id = user.Id;
            this.Name = user.Name;
            this.Email = user.Email;
    }
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public User.UserRole Role { get; set; }
    
}