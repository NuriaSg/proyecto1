﻿namespace proyecto1.Server.Services.CategoryService
{
	public interface ICategoryService
	{
		Task<ServiceResponse<List<Category>>> GetCategories();

	}
}
