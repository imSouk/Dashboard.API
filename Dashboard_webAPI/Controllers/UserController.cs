using Dashboard_webAPI.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace Dashboard_webAPI.Controllers
{
    public class UserController : ControllerBase
    {
        private readonly UserService _userService;
        public UserController(UserService userService)
        {
        _userService = userService;    
        }
    }
}
