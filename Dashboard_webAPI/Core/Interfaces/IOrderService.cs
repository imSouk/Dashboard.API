using Dashboard_webAPI.Core.Application.Dtos;
using Dashboard_webAPI.Core.Domain.Models;

namespace Dashboard_webAPI.Core.Interfaces;

public interface IOrderService
{
    public Task<Order> CreateOrder(OrderDto orderdto);
    public Task<List<Order>> GetAllOrders();
    public Task UpdateOrder(Order order);
    public Task<Order> DeleteOrder(Order order);

}