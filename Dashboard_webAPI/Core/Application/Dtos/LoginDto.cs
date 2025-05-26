using static Dashboard_webAPI.Core.Domain.Models.User;

namespace Dashboard_webAPI.Core.Application.Dtos
{
    public class LoginDto
    {
        public LoginDto(string email, string password, UserRole role)
        {
            Email = email; 
            Password = password;
            Role = role;
        }
        public string Password { get; set; }
        public string Email { get; set; }
        public UserRole Role { get; set; }
    }
}
