using LewisStore.API.Models;
using Microsoft.EntityFrameworkCore;

namespace LewisStore.API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Add your DbSets (tables) here later
        // Example:
        // public DbSet<Product> Products { get; set; }
        // public DbSet<User> Users { get; set; }

        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }

    }
}
