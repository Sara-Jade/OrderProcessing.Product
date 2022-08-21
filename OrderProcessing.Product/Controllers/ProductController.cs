using Microsoft.AspNetCore.Mvc;
using OrderProcessing.Product.Data;
using OrderProcessing.Product.Models;

namespace OrderProcessing.Product.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : Controller
    {
        private IProductRepository _productRepository;
        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet("GetAllProducts")]
        public async Task<List<Item>> GetAllProducts()
        {
            return await _productRepository.GetAllProducts();
        }
    }
}
