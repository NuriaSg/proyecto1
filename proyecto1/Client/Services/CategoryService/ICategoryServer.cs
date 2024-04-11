namespace proyecto1.Client.Services.CategoryService
{
	public interface ICategoryServer
	{
		List<Category> Categories { get; set; }
		Task GetCategories();
	}
}
