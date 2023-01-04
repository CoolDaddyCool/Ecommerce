namespace Ecommerce.Client.Services
{
    public interface IProductService
    {
        event Action ProductsChange;

        public List<Product> Products { get; set; }

        Task GetProducts(string? categoryUrl = null);
        Task<ServiceResponse<Product>> GetProductById(int productId);   
    }
}
