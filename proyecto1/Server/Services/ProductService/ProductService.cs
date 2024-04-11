
namespace proyecto1.Server.Services.ProductService
{
	public class ProductService : IProductService
	{
		private readonly DataContext _context;
		public ProductService(DataContext context)
		{
			_context = context;
		}

		public async Task<ServiceResponse<List<Product>>> GetProductsAsync() //Envia todos los productos
		{
			var response = new ServiceResponse<List<Product>>
			{
				Data = await _context.Products.ToListAsync()
			};
			return response;
		}

		public async Task<ServiceResponse<Product>> GetProductAsync(int productId) //Metodo que envia un unico producto al cliente o un mensaje en caso de error
		{
			var response = new ServiceResponse<Product>();
			var product = await _context.Products.FindAsync(productId);
			if (product == null)
			{
				response.Success = false;
				response.Message = "Sorry but this product doesn't exits.";
			}
			else
			{
				response.Data = product;
			}
			return response;
		}

		public async Task<ServiceResponse<List<Product>>> GetProductsByCategory(string categoryUrl) //Metodo que envia los productos donde la categoria coincide con la recibida
		{
			{
				var respose = new ServiceResponse<List<Product>>
				{
					Data = await _context.Products
						.Where(p => p.Category.Url.ToLower().Equals(categoryUrl.ToLower()))
						.ToListAsync()
				};
				return respose;

			}
		}
	}
}
