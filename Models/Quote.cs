namespace TestApp.Models
{
    public class Quote
    {
        public int Id { get; set; }
        public string CustomerName { get; set; } = string.Empty;
        public string ProductName { get; set; } = string.Empty;
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice => UnitPrice * Quantity;
        public DateTime CreatedDate { get; set; }
        public string Status { get; set; } = "Draft";
        public string Comments { get; set; } = string.Empty;
    }
}