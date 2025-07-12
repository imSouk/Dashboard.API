using System.ComponentModel.DataAnnotations.Schema;

namespace Dashboard_webAPI.Core.Application.Dtos
{
    public class OrderDto
    {
        public string ProductName { get; set; }
        
        public string OrderDescription { get; set; }
        public int BaseSellingQuantity { get; set; }
        
    }
}
