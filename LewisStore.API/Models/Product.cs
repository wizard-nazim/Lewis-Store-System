namespace LewisStore.API.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string SKU { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal UnitPrice { get; set; }
        public int StockQty { get; set; }
        public bool IsActive { get; set; }
    }
}
