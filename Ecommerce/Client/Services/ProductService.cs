namespace Ecommerce.Client.Services
{
    public class ProductService : IProductService
    {
        private readonly HttpClient http;

        public event Action ProductsChange;

        public ProductService(HttpClient http)
        {
            this.http = http;
        }

        public List<Product> Products { get; set; } = new();

        public async Task GetProducts(string? categoryUrl = null)
        {
            var result = categoryUrl == null ?
                await http.GetFromJsonAsync<ServiceResponse<List<Product>>>("api/product") :
                await http.GetFromJsonAsync<ServiceResponse<List<Product>>>($"api/product/category/{categoryUrl}");
            if (result != null && result.Data != null)
            {
                Products = result.Data;
            }

            ProductsChange.Invoke();
        }

        public async Task<ServiceResponse<Product>> GetProductById(int productId)
        {
            var result = await http.GetFromJsonAsync<ServiceResponse<Product>>($"api/product/{productId}");
            return result;
        }
    }
}
