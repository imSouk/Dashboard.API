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
        public async Task<Order> CreateOrder(Order order)
        {
            //The order cannot arrive here void?
            //maybe we can verify if the order already exists? or this will make that for us?
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
            throw new NotImplementedException();
        }

       
    }
}
