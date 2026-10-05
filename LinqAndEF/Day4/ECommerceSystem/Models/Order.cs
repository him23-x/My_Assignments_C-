using System;
using System.Collections.Generic;

namespace ECommerceSystem.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }

        // Many-to-One with Customer
        public int CustomerId { get; set; }
        public Customer Customer { get; set; } = null!;

        // Many-to-Many with Product through OrderDetail
        public ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
    }
}
