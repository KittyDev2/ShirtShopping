using Microsoft.EntityFrameworkCore;

namespace ShirtShooping.PoductAPI.Model.Context
{
    public class MySQLContext : DbContext
    {
        public MySQLContext() {}
        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options) {}

        public DbSet<Product> Products { get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 2,
                Name = "Name",
                Price = new decimal (69.9),
                Description = "Camisa Palmeiras - XG",
                ImageUrl = "https://github.com/KittyDev2/ShirtShopping/blob/master/ShoppingImages/768978_01.png?raw=true",
                CategoryName = "Football T-Shirt"
            });
        }
    }
}
