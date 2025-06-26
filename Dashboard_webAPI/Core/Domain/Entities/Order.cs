using System.ComponentModel.DataAnnotations.Schema;

namespace Dashboard_webAPI.Core.Domain.Models;

public class Order
{
    public Guid Id { get; set; }   
    public string ProductName { get; set; }

    public string OderDescription { get; set; }
    [Column(TypeName = "decimal(18, 2)")]
    public decimal Base_selling_price { get; set; }
    public int Base_selling_quantity { get; set; }
    
}