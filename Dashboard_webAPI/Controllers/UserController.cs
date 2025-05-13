using Dashboard_webAPI.Core.Dtos;
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

        [HttpPost]
        [Route("/User/Register")]
        public async Task<IActionResult> RegisterUser([FromBody]UserDto userDto)
        {
            try
            {
                await _userService.CreateUser(userDto);
                return Ok();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return BadRequest();
            }    
        }

        [HttpGet]
        [Route("/User/Login")]
        public async Task<IActionResult> UserLoginRequest(UserDto userDto)
        {   
            string response = String.Empty;
            response = await _userService.LoginTask(userDto);
            if(response == "Autorized")
            {
                return Ok();
            }
            return NotFound();
        }
        [HttpPost]
        [Route("/User/DeleteUser")]
        public async  Task<IActionResult> DeleteUser([FromBody]UserDto userDto)
        {
            var  response =    _userService.DeleteUser(userDto);
            return Ok(response);
        }
    }
}
