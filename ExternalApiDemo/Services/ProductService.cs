using ExternalApiDemo.Models;
using ExternalApiDemo.Repositories;

namespace ExternalApiDemo.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public Task<IEnumerable<Product>> GetAllProductsAsync()
        {
            return _productRepository.GetAllProductsAsync();
        }

        public Task<Product?> GetProductByIdAsync(int id)
        {
            return _productRepository.GetProductByIdAsync(id);
        }

        public Task<Product?> UpdateProductAsync(int id, Product updatedProduct)
        {
            return _productRepository.UpdateProductAsync(id, updatedProduct);
        }
    }
}
