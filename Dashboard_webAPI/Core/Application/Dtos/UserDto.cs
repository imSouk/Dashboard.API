using Dashboard_webAPI.Core.Domain.Models;
using Microsoft.AspNetCore.Identity; 

namespace Dashboard_webAPI.Core.Application.Dtos;

public class UserDto 
{
 
    public UserDto(string name ,string email, string password)
    {
        Name = name;
        Email = email;
        Password = password;
       }
 
    public string Name { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
   
    
}