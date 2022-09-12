using OrderProcessing.Product.Models;

namespace OrderProcessing.Product
{
    public class ProductRepository : IProductRepository
    {
        private readonly List<Merchandise> products = new List<Merchandise>();

        public ProductRepository()
        {
            products.Add(new Merchandise
            {
                Id = Guid.NewGuid(),
                Name = "Samsung Mobile",
                Quantity = 25,
                Price = 90000
            });

            products.Add(new Merchandise
            {
                Id = Guid.NewGuid(),
                Name = "Motorola Mobile",
                Quantity = 50,
                Price = 65000
            });

            products.Add(new Merchandise
            {
                Id = Guid.NewGuid(),
                Name = "OnePlus Mobile",
                Quantity = 15,
                Price = 55000
            });
        }
        public Task<List<Merchandise>> GetAllProducts()
        {
            return Task.FromResult(products);
        }
    }
}
