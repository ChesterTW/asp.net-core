using Microsoft.EntityFrameworkCore;

namespace ShopWebsite.Data
{
    public class ShopWebContext : DbContext
    {
        public ShopWebContext() { }
        public ShopWebContext(DbContextOptions<ShopWebContext> options) : base(options) { }

        public DbSet<Product> Posts { get; set; }
        public DbSet<Category> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("server=localhost;database=ShopWeb;uid=raccoon;pwd=123456", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.27-mysql"));
            }
        }


    }
}