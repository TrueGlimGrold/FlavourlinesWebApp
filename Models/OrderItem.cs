namespace FlavourlinesWebApp.Models
{
    public class OrderItem
    {

        public int OrderItemId { get; set; }
        public int OrderId { get; set; } // Foreign key for Order
        public int ProductId { get; set; } // Foreign key for Product
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }

        public Product Product { get; set; }
        public CustomerOrder Order { get; set; }

        // Default Constructor
        public OrderItem() { }

        // Parameterized Constructor
        public OrderItem(int orderItemId, int orderId, int productId, int quantity, decimal unitPrice, decimal totalPrice)
        {
            OrderItemId = orderItemId;
            OrderId = orderId;
            ProductId = productId;
            Quantity = quantity;
            UnitPrice = unitPrice;
            TotalPrice = totalPrice;
        }
    }
}
