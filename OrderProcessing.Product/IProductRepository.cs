using OrderProcessing.Product.Models;

namespace OrderProcessing.Product
{
    public interface IProductRepository
    {
        public Task<List<Merchandise>> GetAllProducts();
    }
}
