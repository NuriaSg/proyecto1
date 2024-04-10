namespace proyecto1.Server.Data
{
	public class DataContext : DbContext
	{
        public DataContext(DbContextOptions<DataContext>options): base(options)
        {
            
        }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Product>().HasData(
				new Product
				{
					Id = 1,
					Title = "Classic Rubik's Cube",
					Description = "The Rubik's Cube is a three-dimensional mechanical puzzle created by Hungarian sculptor and architecture professor Ernő Rubik in 1974.",
					Image = "./media/cubo1.png",
					Price = 9.99m
				},
				new Product
				{
					Id = 2,
					Title = "Pyraminx",
					Description = "The Pyraminx is a mechanical puzzle shaped like a tetrahedron similar to a Rubik's cube. It was invented by Uwe Meffert in 1970.",
					Image = "./media/cubo2.jpg",
					Price = 7.99m
				},
				new Product
				{
					Id = 3,
					Title = "Skewb",
					Description = "The Skewb is a three-dimensional mechanical puzzle like a Rubik's cube, made up of pieces that can rotate and change position.",
					Image = "./media/cubo3.jpg",
					Price = 9.99m
				});
				}

		public DbSet<Product> Products { get; set; }
    }
}
