using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

//Controlador de los servicios de Productos


namespace proyecto1.Server.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductController : ControllerBase
	{
		
		private readonly DataContext _context;

		public ProductController(DataContext context)
		{
            _context = context;
        }

		//enlaces a todos los metodos creados en el service GETTER
		[HttpGet]
		public async Task<ActionResult<ServiceResponse<List<Product>>>> GetProducts()
		{
			var result = await _context.Products.ToListAsync();
			if(result is not null)
			{
				foreach(var item in result)
				{
					item.Category  = await _context.Categories.FirstOrDefaultAsync(c => c.Id == item.CategoryId);
				}
			}
			return Ok(result);
		}

		[HttpGet("{productId}")]
		
		public async Task<ActionResult<ServiceResponse<Product>>> GetProduct(int productId)
		{
			var result = await _context.Products.FirstOrDefaultAsync(c => c.Id == productId);
			return Ok(result);
		}

		[HttpGet("category/{categoryUrl}")]
        public async Task<ActionResult<ServiceResponse<List<Product>>>> GetProductSByCategory(string categoryUrl)
        {
            var result = await _context.Products.Where(p => p.Category.Url.ToLower()
			.Equals(categoryUrl.ToLower())).ToListAsync();
            return Ok(result);
        }

      
       
    }

}
