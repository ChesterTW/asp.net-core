using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace animalWiki.Models
{
    public partial class AnimalWikiContext : DbContext
    {
        public AnimalWikiContext()
        {
        }

        public AnimalWikiContext(DbContextOptions<AnimalWikiContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Animal> Animals { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySql("server=localhost;database=animalWiki;uid=raccoon;pwd=123456", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.29-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("utf8mb4_0900_ai_ci")
                .HasCharSet("utf8mb4");

            modelBuilder.Entity<Animal>(entity =>
            {
                entity.ToTable("Animal");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ChName).HasColumnName("chName");

                entity.Property(e => e.Content).HasColumnName("content");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.EnName).HasColumnName("enName");

                entity.Property(e => e.Img).HasColumnName("img");

                entity.Property(e => e.LoveCount).HasColumnName("loveCount");

                entity.Property(e => e.Loved).HasColumnName("loved");

                entity.Property(e => e.Saved).HasColumnName("saved");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
