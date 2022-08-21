namespace OrderProcessing.Product.Models
{
    public class Item
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = "Wachamacallit";
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
