namespace Ecommerce.Client.Services
{
    public interface IProductService
    {
        public List<Product> Products { get; set; }

        Task GetAllProducts();
        Task<ServiceResponse<Product>> GetProductById(int productId);   
    }
}
