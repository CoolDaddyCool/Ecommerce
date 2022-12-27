namespace Ecommerce.Client.Services
{
    public class ProductService : IProductService
    {
        private readonly HttpClient http;

        public ProductService(HttpClient http)
        {
            this.http = http;
        }

        public List<Product> Products { get; set; } = new();

        public async Task GetAllProducts()
        {
            var result = await http.GetFromJsonAsync<ServiceResponse<List<Product>>>("api/product");
            if (result != null && result.Data != null)
            {
                Products = result.Data;
            }
        }

        public async Task<ServiceResponse<Product>> GetProductById(int productId)
        {
            var result = await http.GetFromJsonAsync<ServiceResponse<Product>>($"api/product/{productId}");
            return result;
        }
    }
}
