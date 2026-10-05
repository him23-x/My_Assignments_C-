using System.Collections.Generic;

namespace ECommerceSystem.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }

        // Many-to-One with Category
        public int CategoryId { get; set; }
        public Category Category { get; set; } = null!;

        // Many-to-Many with Order through OrderDetail
        public ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
    }
}
