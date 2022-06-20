using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ShopAPI.Models
{
    public class ShopContext : DbContext
    {
        public ShopContext()
        {
        }

        public ShopContext(DbContextOptions<ShopContext> options)
            : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("server=localhost;database=ShopApi;uid=raccoon;pwd=123456", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.29-mysql"));
            }
        }

        // protected override void OnModelCreating(ModelBuilder modelBuilder)
        // {
        //     modelBuilder.UseCollation("utf8mb4_0900_ai_ci")
        //         .HasCharSet("utf8mb4");

        //     modelBuilder.Entity<Category>(entity =>
        //     {
        //         entity.ToTable("Category");
        //     });

        //     modelBuilder.Entity<Product>(entity =>
        //     {
        //         entity.ToTable("Product");

        //         entity.HasIndex(e => e.CategoryId, "CategoryId");

        //         entity.HasOne(d => d.Category)
        //             .WithMany(p => p.Products)
        //             .HasForeignKey(d => d.CategoryId)
        //             .HasConstraintName("product_ibfk_1");
        //     });

        //     OnModelCreatingPartial(modelBuilder);
        // }

        // partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
