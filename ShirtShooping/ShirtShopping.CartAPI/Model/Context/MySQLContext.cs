using Microsoft.EntityFrameworkCore;

namespace ShirtShopping.CartAPI.Model.Context
{
    public class MySQLContext : DbContext
    {
        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options) {}

        public DbSet<Product> Products { get; set;}
        
        public DbSet<CartDetail> CartDetails { get; set;}
        
        public DbSet<CartHeader> CartHeaders { get; set;}
    }
}
