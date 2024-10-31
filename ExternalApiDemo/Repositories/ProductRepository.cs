using System.Text.Json;
using System.Text;
using ExternalApiDemo.Models;

namespace ExternalApiDemo.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly HttpClient _httpClient;

        public ProductRepository(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<Product>> GetAllProductsAsync()
        {
            var response = await _httpClient.GetAsync("userdetail");
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<IEnumerable<Product>>(content) ?? Enumerable.Empty<Product>();
        }

        public async Task<Product?> GetProductByIdAsync(int id)
        {
            var response = await _httpClient.GetAsync($"products/{id}");
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<Product>(content);
        }

        public async Task<Product?> UpdateProductAsync(int id, Product updatedProduct)
        {
            var content = new StringContent(
                JsonSerializer.Serialize(updatedProduct),
                Encoding.UTF8,
                "application/json"
            );

            var response = await _httpClient.PutAsync($"products/{id}", content);
            response.EnsureSuccessStatusCode();

            var responseContent = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<Product>(responseContent);
        }
    }
}
