using Dashboard_webAPI.Core.Domain.Models;

namespace Dashboard_webAPI.Core.Interfaces;

public interface IOrderRepository
{
    Task AddOrder(Order oder);
    Task<Order> FindByIdAsync(Guid id);
    Task<Order> FindByNameAsync(string name);
    Task UpdateOrder(Order order);
    Task DeleteOrder(Order order);
    Task SaveChangesAsync();
}