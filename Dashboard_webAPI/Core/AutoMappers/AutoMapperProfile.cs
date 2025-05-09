using AutoMapper;
using Dashboard_webAPI.Core.Dtos;
using Dashboard_webAPI.Core.Models;

namespace Dashboard_webAPI.Core.AutoMappers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile() 
        {
            CreateMap<User, UserDto>().
                ReverseMap();
        }
    }
}
