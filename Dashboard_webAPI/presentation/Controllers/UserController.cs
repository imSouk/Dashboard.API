using Dashboard_webAPI.Core.Application.Dtos;
using Dashboard_webAPI.Core.Interfaces;
using Dashboard_webAPI.Infrastructure.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Dashboard_webAPI.presentation.Controllers
{
    [Authorize]
    [ApiController]
    [Route("/User")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
        _userService = userService;    
        }
        [AllowAnonymous]
        [HttpPost]
        [Route("/Register")]
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

        [AllowAnonymous]
        [HttpPost]
        [Route("/User/Login")]
        public async Task<ActionResult<dynamic>> UserLoginRequest([FromBody]LoginDto userDto)
        {        
            var response = await _userService.LoginTask(userDto);
            if (response[0] == "Autorized")
            {
                return new
                {
                    user = userDto,
                    token = response[1],
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
