using Microsoft.AspNetCore.Identity;

namespace FlavourlinesWebApp.Models
{
    public class CustomerOrder
    {

        public int CustomerOrderId { get; set; }
        public int UserId { get; set; } // Foreign key for User
        public DateTime OrderDate { get; set; }
        public string Status { get; set; }
        public decimal TotalPrice { get; set; }
        public string ShippingAddress { get; set; }
        public string BillingAddress { get; set; }
        public int PaymentId { get; set; } // Foreign key for Payment
        public int ShippingId { get; set; } // Assuming a Shipping table exists

        public User User { get; set; } // Use IdentityUser for the User reference
        public Payment Payment { get; set; }

        // Default Constructor
        public CustomerOrder() { }

        // Parameterized Constructor
        public CustomerOrder(int orderId, int userId, DateTime orderDate, string status, decimal totalPrice, string shippingAddress, string billingAddress, int paymentId, int shippingId)
        {
            CustomerOrderId = orderId;
            UserId = userId;
            OrderDate = orderDate;
            Status = status;
            TotalPrice = totalPrice;
            ShippingAddress = shippingAddress;
            BillingAddress = billingAddress;
            PaymentId = paymentId;
            ShippingId = shippingId;
        }
    }
}
