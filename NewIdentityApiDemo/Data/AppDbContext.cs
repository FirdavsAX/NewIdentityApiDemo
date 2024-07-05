using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NewIdentityApiDemo.Entities;

namespace NewIdentityApiDemo.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options,IConfiguration configuration) : IdentityDbContext<AppUser>(options)
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
    }
}
