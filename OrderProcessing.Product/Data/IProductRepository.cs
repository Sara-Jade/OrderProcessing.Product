using OrderProcessing.Product.Models;

namespace OrderProcessing.Product.Data
{
    public interface IProductRepository
    {
        public Task<List<Item>> GetAllProducts();
    }
}
