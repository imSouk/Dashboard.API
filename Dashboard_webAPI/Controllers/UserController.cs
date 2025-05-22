using Dashboard_webAPI.Core.Dtos;
using Dashboard_webAPI.Core.Interfaces;
using Dashboard_webAPI.Core.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Dashboard_webAPI.Controllers
{
    [Authorize]
    [ApiController]
    [Route("User")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
        _userService = userService;    
        }

        [HttpPost]
        [Route("/User/Register")]
        public async Task<IActionResult> RegisterUser([FromBody]UserDto userDto)
        {
            var response = await _userService.CreateUser(userDto);   
            if(response == null )
            {
                return Ok();
            }if(!ModelState.IsValid)
                return BadRequest(ModelState);
        return Ok(); 
        }

        [HttpPost]
        [Route("/User/Login")]
        public async Task<ActionResult<dynamic>> UserLoginRequest([FromBody]LoginDto userDto)
        {   
            string response = String.Empty; 
            response = await _userService.LoginTask(userDto);
            if(response == "Autorized")
            {
                return new
                {
                    user = userDto,
                    token = response,
                };
            }
            return NotFound(new{ message = "usuário ou senha inválidos" });
        }
        [HttpPost]
        [Route("/User/DeleteUser")]
        public async  Task<IActionResult> DeleteUser([FromBody]LoginDto userDto)
        {
            var  response = await _userService.DeleteUser(userDto);
            if(response != null) 
            {
                return Ok(response);
            }
            return BadRequest(ModelState);
        }
    }
}
