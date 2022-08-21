using OrderProcessing.Product.Models;

namespace OrderProcessing.Product.Data
{
    public class ProductRepository : IProductRepository
    {
        private readonly List<Item> products = new List<Item>();

        public ProductRepository()
        {
            products.Add(new Item
            {
                Id = Guid.NewGuid(),
                Name = "Samsung Mobile",
                Quantity = 25,
                Price = 90000
            });

            products.Add(new Item
            {
                Id = Guid.NewGuid(),
                Name = "Motorola Mobile",
                Quantity = 50,
                Price = 65000
            });

            products.Add(new Item
            {
                Id = Guid.NewGuid(),
                Name = "OnePlus Mobile",
                Quantity = 15,
                Price = 55000
            });
        }
        public Task<List<Item>> GetAllProducts()
        {
            return Task.FromResult(products);
        }
    }
}

