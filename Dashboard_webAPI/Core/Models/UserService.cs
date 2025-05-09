using Dashboard_webAPI.Core.AutoMappers;
using Dashboard_webAPI.Core.Dtos;
using Dashboard_webAPI.Core.Interfaces;

namespace Dashboard_webAPI.Core.Models;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;
    private readonly AutoMapperProfile _mapper;
    
    public UserService(UserRepository userRepository, AutoMapperProfile autoMaperProfile)
    {
        _userRepository = userRepository;
        _mapper = autoMaperProfile;
        _mapper.CreateMap<UserDto, User>();
    }
    public async Task CreateUser(UserDto user)
    {
        try
        {
            if(user != null) 
            {
              var  response = await _userRepository.FindByIdAsync(user.Id);
               if(response == null) 
                {
                    User User = new User();
                    _userRepository
                }
            }
        }
        catch (Exception ex) { Console.WriteLine(ex); }
    }

    public Task DeleteUser(UserDto user)
    {
        throw new NotImplementedException();
    }

    public Task<List<UserDto>> GetAllUsers()
    {
        throw new NotImplementedException();
    }

    public Task<UserDto> GetUser(UserDto user)
    {
        throw new NotImplementedException();
    }

    public Task UpdateUser(UserDto user)
    {
        throw new NotImplementedException();
    }
    
}