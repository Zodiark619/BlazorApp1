
namespace BlazorApp1.Server.Data
{
	public class DataContext:DbContext
	{
		public DataContext(DbContextOptions<DataContext> options):base(options)
		{

		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Product>().HasData(
				new Product
				{
					Id = 1,
					Title = "Hithicker's Guide to GALAZZY",
					Description = "kmzkmzkmzkzmkzmkzmkz",
					ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/5/5e/Domestic_Cat_Face_Shot.jpg",
					Price = 9.99m
				},
		new Product
		{
			Id = 2,
			Title = "Bucin KKKKmz",
			Description = "Ready play sefnefnef",
			ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/4/4f/Felis_silvestris_catus_lying_on_rice_straw.jpg",
			Price = 7.99m
		},new Product
		{
			Id = 3,
			Title = "Konto konto Neonn KssssI",
			Description = "HJHHjasjdajs",
			ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/b/bb/Kittyply_edit1.jpg",
			Price = 19.99m
		}
			
			);
		}


		public DbSet<Product> Products { get; set; }
	}
}
