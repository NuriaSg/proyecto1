
using System.Net.Http.Json;

namespace proyecto1.Client.Services.ProductService
{
	public class ProductService : IProductService
	{
		private readonly HttpClient _http;
		public List<Product> Products { get; set; } = new List<Product>();

		public event Action ProductsChanged;
		public ProductService(HttpClient http)
		{
			_http = http;
		}

        public async Task<ServiceResponse<Product>> GetProduct(int productId) //Obtiene un solo producto según la Id
		{
			var result = await _http.GetFromJsonAsync<ServiceResponse<Product>>($"api/product/{productId}");
			return result;
		}

		public async Task GetProducts(string? categoryUrl = null) //Obtiene todos los productos o los productos de una sola categoria según se utilice
		{
			var result = categoryUrl == null ? await _http.GetFromJsonAsync<ServiceResponse<List<Product>>>("api/product"):
											   await _http.GetFromJsonAsync<ServiceResponse<List<Product>>>($"api/product/category/{categoryUrl}");

            if (result != null && result.Data != null)
				Products = result.Data;
			ProductsChanged.Invoke();
		}

     
    }
}
