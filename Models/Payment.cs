namespace FlavourlinesWebApp.Models
{
    public class Payment
    {

        public int PaymentId { get; set; }
        public int CustomerOrderId { get; set; } // Foreign key for Order
        public DateTime PaymentDate { get; set; }
        public decimal Amount { get; set; }
        public string PaymentMethod { get; set; }
        public string TransactionId { get; set; }
        public string Status { get; set; }

        public CustomerOrder CustomerOrder { get; set; }

        // Default Constructor
        public Payment() { }

        // Parameterized Constructor
        public Payment(int paymentId, int orderId, DateTime paymentDate, decimal amount, string paymentMethod, string transactionId, string status)
        {
            PaymentId = paymentId;
            CustomerOrderId = orderId;
            PaymentDate = paymentDate;
            Amount = amount;
            PaymentMethod = paymentMethod;
            TransactionId = transactionId;
            Status = status;
        }

    }
}
