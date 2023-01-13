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
        public string Message { get; set; } = "Loading products";

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

        public async Task SearchProducts(string searchText)
        {
            var result = await http
                .GetFromJsonAsync<ServiceResponse<List<Product>>>($"api/product/search/{searchText}");

            if (result != null && result.Data != null)
            {
                Products = result.Data;
            }
            if (Products.Count == 0)
            {
                Message = "No Products found.";
            }
            ProductsChange?.Invoke();
        }

        public async Task<List<string>> GetProductSearchSuggestions(string searchText)
        {
            var result = await http
                .GetFromJsonAsync<ServiceResponse<List<string>>>($"api/product/searchsuggestions/{searchText}");

            return result.Data;
        }
    }
}
