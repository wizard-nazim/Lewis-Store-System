namespace LewisStore.API.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public decimal Total { get; set; }
        public string PaymentType { get; set; } // Cash or Credit
        public string Status { get; set; } // Pending, Paid, etc.
    }
}
