using Dashboard_webAPI.Core.Domain.Models;
using Dashboard_webAPI.Core.Interfaces;
using Dashboard_webAPI.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Dashboard_webAPI.Infrastructure;

public class OrderRepository : IOrderRepository
{
    private readonly DashboardContext _context;
    public OrderRepository(DashboardContext context)
    {
        _context = context;
    }
    public async Task AddOrder(Order order) => _context.Add(order);
    public async Task<Order> FindByIdAsync(Guid id)
    {
            var orderFinded = await _context.Orders.FindAsync(id);    
            return orderFinded;
    }
    public async Task<Order> FindByNameAsync(string name)
    {
       var orderFinded =  await _context.Orders.FirstOrDefaultAsync(order => order.ProductName == name);
       return orderFinded;
    }
  //Think about "how can i effectively update an order?"
    public Task UpdateOrder(Order order)
    {
         _context.Orders.Update(order);   
        return Task.CompletedTask;
    }
    public Task DeleteOrder(Order order)
    {
        _context.Orders.Remove(order);
        return Task.CompletedTask;
    }
    public async Task SaveChangesAsync() => await _context.SaveChangesAsync();
}