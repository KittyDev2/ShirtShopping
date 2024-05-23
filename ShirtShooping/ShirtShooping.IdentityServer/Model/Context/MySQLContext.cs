using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ShirtShooping.IdentityServer.Model.Context;

public class MySQLContext : IdentityDbContext<ApplicationUser>
{
    public MySQLContext(DbContextOptions<MySQLContext> options) 
        : base(options)
    {
    }
}