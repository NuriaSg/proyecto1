using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


//Controlador de los servicios de Categoria
namespace proyecto1.Server.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CategoryController : ControllerBase
	{
		private readonly DataContext _context;

		public CategoryController(DataContext context) 
		{
            _context = context;
        }

		[HttpGet]
		//ActionResult para poder usar swagger
		public async Task<ActionResult<ServiceResponse<List<Category>>>> GetCategories()
		{
			var result = await _context.Categories.ToListAsync();
			return Ok(result);
		}
	}
}
