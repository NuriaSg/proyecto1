using proyecto1.Shared;

namespace proyecto1.Client.Services.ProductService
{
	public interface IProductService
	{
		event Action ProductsChanged;
		List<Product> Products { get; set; }
		Task GetProducts(string categoryUrl =null);
		Task<ServiceResponse<Product>> GetProduct(int productId);
		//Esta vez es Service Response porque devuelve el response.succes y .message
	}
}
