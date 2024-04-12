using Microsoft.EntityFrameworkCore;
using proyecto1.Shared;

namespace proyecto1.Server.Data
{
	//Clase para introducir todos los objetos a la base de datos
	public class DataContext : DbContext
	{
        public DataContext(DbContextOptions<DataContext>options): base(options)
        {
            
        }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Category>().HasData(
				new Category
				{
					Id= 1,
					Name= "Square Cubes",
					Url= "square-cubes"

				},
				new Category
				{
					Id= 2,
					Name= "Triangular Cubes",
					Url= "triangular-cubes"

				},
				new Category
				{
					Id = 3,
					Name = "Special cubes",
					Url = "special-cubes"

				}


				);

			modelBuilder.Entity<Product>().HasData(
				new Product
				{
					Id = 1,
					Title = "Classic Rubik's Cube",
					Description = "The Rubik's Cube is a three-dimensional mechanical puzzle created by Hungarian sculptor and architecture professor Ernő Rubik in 1974.",
					Image = "./media/cubo1.png",
					Price = 9.99m,
					CategoryId = 1
					
				},
				new Product
				{
					Id = 2,
					Title = "Pyraminx",
					Description = "The Pyraminx is a mechanical puzzle shaped like a tetrahedron similar to a Rubik's cube. It was invented by Uwe Meffert in 1970.",
					Image = "./media/cubo2.jpg",
					Price = 7.99m,
					CategoryId = 2

				},
				new Product
				{
					Id = 3,
					Title = "Skewb",
					Description = "The Skewb is a three-dimensional mechanical puzzle like a Rubik's cube, made up of pieces that can rotate and change position.",
					Image = "./media/cubo3.jpg",
					Price = 9.99m,
					CategoryId = 3

				},
				new Product
				{
					Id = 4,
					Title = "Megaminx",
					Description = "The Megaminx, or \"Magic Dodecahedron\", was invented by several people simultaneously and produced by different manufacturing companies with slightly different designs.\r\nThe Megaminx has the shape of a dodecahedron, it has 12 central pieces, one on each face; 20 corners and 30 edges.",
					Image = "./media/cubo4.jpg",
					Price = 20.99m,
					CategoryId = 3

				});
				}

		public DbSet<Product> Products { get; set; }
		public DbSet<Category> Categories { get; set; }

	}
}
