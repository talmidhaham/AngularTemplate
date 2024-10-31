using ExternalApiDemo.Models;

namespace ExternalApiDemo.Services
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetAllProductsAsync();
        Task<Product?> GetProductByIdAsync(int id);
        Task<Product?> UpdateProductAsync(int id, Product updatedProduct);
    }
}
