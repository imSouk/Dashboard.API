using System.ComponentModel.DataAnnotations;
using Dashboard_webAPI.Core.Dtos;

namespace Dashboard_webAPI.Core.Models;

public class User
{ 
    public User(UserDto userDto)
    {
         this.Id = userDto.Id;
         this.Name = userDto.Name;
         this.Email = userDto.Email;
         this.Password = null;
    }
    public enum UserRole 
    {
        Admin,
        Costumer,
    };
    public int Id { get; set; }
    [Required]
    [StringLength(15, MinimumLength = 2)]
    public string Name { get; set; }
    [Required]
    [StringLength(15, MinimumLength = 7)]
    public string? Password { get; set; }
    [Required]
    [EmailAddress]
    [StringLength(100, MinimumLength = 8)]
    public string? Email { get; set; }
    public UserRole Role { get; set; }
    public User()
    {
            
    }


}