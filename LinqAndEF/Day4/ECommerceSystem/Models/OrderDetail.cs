namespace ECommerceSystem.Models
{
    // Join entity for the Order <-> Product many-to-many relationship
    public class OrderDetail
    {
        public int OrderId { get; set; }
        public Order Order { get; set; } = null!;

        public int ProductId { get; set; }
        public Product Product { get; set; } = null!;

        public int Quantity { get; set; }
    }
}
