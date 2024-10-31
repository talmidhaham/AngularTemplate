using ExternalApiDemo.Models;

namespace ExternalApiDemo.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAllProductsAsync();
        Task<Product?> GetProductByIdAsync(int id);
        Task<Product?> UpdateProductAsync(int id, Product updatedProduct);
    }
}
