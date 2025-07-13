using Dashboard_webAPI.Core.Application.Dtos;
using Dashboard_webAPI.Core.Domain.Models;
using Dashboard_webAPI.Core.Interfaces;

namespace Dashboard_webAPI.Infrastructure.Services
{
    public class OrderService: IOrderService
    {
        private readonly IOrderRepository _context;

        public OrderService(IOrderRepository orderRepository)
        {
            _context = orderRepository;

        }
        public async Task<Order> CreateOrder(OrderDto orderdto, string id)
        {

            Order order = Order.CreateOrder(orderdto, id);
            try
            {
                await _context.AddOrder(order);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while creating the order.", ex);
            }
            return order;
        }
         public async Task UpdateOrder(Order order)
        {
            await _context.UpdateOrder(order);
            await _context.SaveChangesAsync();
        }
        public async Task<Order> DeleteOrder(Order order)
        {
            await _context.DeleteOrder(order);
            await _context.SaveChangesAsync();
            return order;
        }

        public Task<List<Order>> GetAllOrders()
        {
            var orders = _context.GetAllOrders();
            return orders;

        }

       
    }
}
