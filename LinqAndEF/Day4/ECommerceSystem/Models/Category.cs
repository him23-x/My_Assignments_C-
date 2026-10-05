using System.Collections.Generic;

namespace ECommerceSystem.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        // One-to-Many: a category has many products
        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
