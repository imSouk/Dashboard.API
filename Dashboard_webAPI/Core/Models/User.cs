using System.ComponentModel.DataAnnotations;
using Dashboard_webAPI.Core.Dtos;

namespace Dashboard_webAPI.Core.Models;

public class User
{
    public enum UserRole
    {
        Admin,
        Costumer,
    };
    public Guid Id { get; set; }
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
    public static User BasicDto(UserDto user) => new User
    {
        Id = user.Id,
        Name = user.Name,
        Email = user.Email,
    };
    public static User FullDtoInfos(UserDto user) => new User 
    {
        Id = user.Id,
        Name = user.Name,
        Password = user.Password,
        Email = user.Email,
        Role= user.Role,
    };


}