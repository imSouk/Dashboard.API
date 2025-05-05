using Dashboard_webAPI.Core.Models;

namespace Dashboard_webAPI.Core.Dtos;

public class UserDto 
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public User.UserRole Role { get; set; }
}