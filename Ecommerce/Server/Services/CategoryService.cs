namespace Ecommerce.Server.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly DataContext db;

        public CategoryService(DataContext db)
        {
            this.db = db;
        }
        public async Task<ServiceResponse<List<Category>>> GetCategories()
        {
            var categories = await db.Categories.ToListAsync();
            return new ServiceResponse<List<Category>>
            {
                Data = categories
            };
        }
    }
}
