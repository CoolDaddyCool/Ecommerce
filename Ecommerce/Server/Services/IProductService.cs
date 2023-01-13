namespace Ecommerce.Server.Services
{
    public interface IProductService
    {
        Task<ServiceResponse<List<Product>>> GetAllProducts();
        Task<ServiceResponse<Product>> GetProductById(int productId);

        Task<ServiceResponse<List<Product>>> GetProductsByCategory(string categoryUrl);

        Task<ServiceResponse<List<Product>>> SearchProducts(string searchText);

        Task<ServiceResponse<List<string>>> GetProductSearchSuggestions(string searchText);
    }
}