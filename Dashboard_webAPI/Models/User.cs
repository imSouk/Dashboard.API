namespace Dashboard_webAPI.Models
{
    public class User
    {  
        public enum UserRole 
        {
         Admin,
         Costumer,
        };
        public int Id { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public UserRole Role { get; set; }
        public User()
        {
            
        }


    }
}
