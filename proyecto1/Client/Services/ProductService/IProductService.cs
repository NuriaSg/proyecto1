using proyecto1.Shared;

namespace proyecto1.Client.Services.ProductService
{
	public interface IProductService
	{
		List<Product> Products { get; set; }
		Task GetProducts();
		Task<ServiceResponse<Product>> GetProduct(int productId);
		//Esta vez es Service Response porque devuelve el response.succes y .message
	}
}
