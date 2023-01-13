namespace Ecommerce.Client.Services
{
    public interface IProductService
    {
        event Action ProductsChange;

        public List<Product> Products { get; set; }

        string Message { get; set; }

        Task GetProducts(string? categoryUrl = null);
        Task<ServiceResponse<Product>> GetProductById(int productId);

        Task SearchProducts(string searchText);
        Task<List<string>> GetProductSearchSuggestions(string searchText);


    }

}
