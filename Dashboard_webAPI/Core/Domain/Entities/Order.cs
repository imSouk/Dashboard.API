using Dashboard_webAPI.Core.Application.Dtos;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dashboard_webAPI.Core.Domain.Models;

public class Order
{
    public enum OrderStats
    {
        // 0 -- 4
        Pending,
        Approved,
        OutForDelivery,
        Compelted,
        Cancelled
    }
    public Guid Id { get; set; }   
    public Guid CustomerId { get; set; }
    public string ProductName { get; set; }

    public string OderDescription { get; set; }
    [Column(TypeName = "decimal(18, 2)")]
    public decimal Base_selling_price { get; set; }
    public int Base_selling_quantity { get; set; }
    public OrderStats orderStats { get; set; }

    public static Order CreateOrder(OrderDto orderDto)
    {
        return new Order
        {
            Id = Guid.NewGuid(), 
            ProductName = orderDto.ProductName,
            OderDescription = orderDto.OrderDescription,
            Base_selling_price = 50 * orderDto.BaseSellingQuantity,
            Base_selling_quantity = orderDto.BaseSellingQuantity,
            orderStats = OrderStats.Pending
        };
    }
}