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
                Name = "Camisa São Paulo",
                Price = new decimal (120.9),
                Description = "Camisa São Paulo Oficial - XG",
                ImageUrl = "https://github.com/KittyDev2/ShirtShopping/blob/master/ShoppingImages/S%C3%A3o-Paulo-FC.jpg?raw=true",
                CategoryName = "Football T-Shirt"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 3,
                Name = "Camisa Corinthians",
                Price = new decimal(120.9),
                Description = "Camisa Corinthians Oficial - XG",
                ImageUrl = "https://github.com/KittyDev2/ShirtShopping/blob/master/ShoppingImages/Corinthians-FC.jpg?raw=true",
                CategoryName = "Football T-Shirt"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 4,
                Name = "Camisa Santos",
                Price = new decimal(120.9),
                Description = "Camisa Santos Oficial - XG",
                ImageUrl = "https://github.com/KittyDev2/ShirtShopping/blob/master/ShoppingImages/Santos-FC.jpeg?raw=true",
                CategoryName = "Football T-Shirt"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 5,
                Name = "Camisa Flamengo",
                Price = new decimal(120.9),
                Description = "Camisa Flamengo Oficial - XG",
                ImageUrl = "https://github.com/KittyDev2/ShirtShopping/blob/master/ShoppingImages/Flamengo-FC.jpg?raw=true",
                CategoryName = "Football T-Shirt"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 6,
                Name = "Camisa Cruzeiro",
                Price = new decimal(120.9),
                Description = "Camisa Cruzeiro Oficial - XG",
                ImageUrl = "https://github.com/KittyDev2/ShirtShopping/blob/master/ShoppingImages/Cruzeiro-FC.jpg?raw=true",
                CategoryName = "Football T-Shirt"
            });
        }
    }
}
