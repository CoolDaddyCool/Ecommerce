using static System.Net.WebRequestMethods;

namespace Ecommerce.Client.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly HttpClient http;

        public CategoryService(HttpClient http)
        {
            this.http = http;
        }
        public List<Category> Categories { get; set; } = new();

        public async Task GetCategories()
        {
            var response = await http.GetFromJsonAsync<ServiceResponse<List<Category>>>("api/Category");
            if (response != null && response.Data != null)
            {
                Categories = response.Data;
            }
        }
    }
}
