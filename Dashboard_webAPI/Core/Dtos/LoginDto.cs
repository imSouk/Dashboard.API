using Dashboard_webAPI.Core.Models;
using static Dashboard_webAPI.Core.Models.User;

namespace Dashboard_webAPI.Core.Dtos
{
    public class LoginDto
    {
        public LoginDto(string email, string password, UserRole role)
        {
            this.Email = email; 
            this.Password = password;
            this.Role = role;
        }
        public string Password { get; set; }
        public string Email { get; set; }
        public User.UserRole Role { get; set; }
    }
}
