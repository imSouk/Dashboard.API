namespace Dashboard_webAPI.Core.Dtos
{
    public class LoginDto
    {
        public LoginDto(string email, string password)
        {
            this.Email = email; 
            this.Password = password;   
        }
        public string Password { get; set; }
        public string Email { get; set; }
    }
}
