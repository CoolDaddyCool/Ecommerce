using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly DataContext db;

        public ProductController(DataContext db)
        {
            this.db = db;
        }


        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
            var products = await db.Products.ToListAsync();
            return Ok(products);
        }
    }
}
