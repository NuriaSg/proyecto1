
namespace proyecto1.Client.Services.CategoryService
{
	public class CategoryService : ICategoryServer
	{
		private readonly HttpClient _http;

		public CategoryService(HttpClient http)
        {
			_http = http;
		}

        public List<Category> Categories { get ; set; } = new List<Category>();

		public async Task GetCategories() //Obtiene la categoria, si no es null devuelve los datos
		{
			var response = await _http.GetFromJsonAsync<ServiceResponse<List<Category>>>("api/Category");
			if(response != null && response.Data != null)
				Categories = response.Data;

		}
	}
}
