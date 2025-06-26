using Dashboard_webAPI.Core.Application.Dtos;
using Dashboard_webAPI.Core.Domain.Models;
using Dashboard_webAPI.Core.Interfaces;
using Dashboard_webAPI.Infrastructure.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Dashboard_webAPI.presentation.Controllers
{
    [Authorize]
    [ApiController]
    [Route("/Orders")]
    public class OrderController : ControllerBase
    
    {
        private readonly IOrderService _orderService;
        public OrderController(IOrderService orderService)
        {
                _orderService = orderService;
        }
        [AllowAnonymous]
        [HttpPost]
        [Route("/CreateOrder")]
        public async Task<IActionResult> Index([FromBody]Order order )
        {
            if (order == null)
            {
                return BadRequest("Order cannot be null");
            }
            var response = await _orderService.CreateOrder(order);
            return Ok();

        }
        [AllowAnonymous]
        [HttpPost]
        [Route("/DeleteOrder")]
        public async Task<IActionResult> DeleteUser([FromBody] Order order)
        {
            if (order == null)
            {
                return BadRequest("Order cannot be null");
            }
            var response = await _orderService.DeleteOrder(order);
            
            return Ok(response);
        }
    }
}
