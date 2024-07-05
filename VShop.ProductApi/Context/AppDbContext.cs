using Microsoft.EntityFrameworkCore;
using VShop.ProductApi.Models;

namespace VShop.ProductApi.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasKey(c => c.CategoryId);  
            modelBuilder.Entity<Category>().
                Property(c => c.Name).
                HasMaxLength(100).
                IsRequired();

            modelBuilder.Entity<Product>().
               Property(c => c.Name).
               HasMaxLength(100).
               IsRequired();

            modelBuilder.Entity<Product>().
               Property(c => c.Description).
               HasMaxLength(500).
               IsRequired();

            modelBuilder.Entity<Product>().
               Property(c => c.ImageURL).
               HasMaxLength(500).
               IsRequired();

            modelBuilder.Entity<Product>().
               Property(c => c.Price).
               HasPrecision(12, 2);

            modelBuilder.Entity<Category>()
               .HasMany(p => p.Products)  
               .WithOne(c => c.Category)
               .IsRequired()
               .OnDelete(DeleteBehavior.Cascade);  

            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, Name = "Eletrônicos" },
                new Category { CategoryId = 2, Name = "Roupas" },
                new Category { CategoryId = 3, Name = "Livros" }
            );
        }
    }
}
