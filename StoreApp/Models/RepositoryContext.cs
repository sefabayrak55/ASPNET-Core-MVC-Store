using Microsoft.EntityFrameworkCore;

namespace StoreApp.Models
{
    public class RepositoryContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public RepositoryContext(DbContextOptions<RepositoryContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>()
                .HasData(
                    new Product() { ProductId=1, ProductName="Computer", ProductPrice= 12_000},
                    new Product() { ProductId=2, ProductName="iPhone", ProductPrice= 13_000},
                    new Product() { ProductId=3, ProductName="Printer", ProductPrice= 14_000},
                    new Product() { ProductId=4, ProductName="Monitor", ProductPrice= 15_000},
                    new Product() { ProductId=5, ProductName="Speaker", ProductPrice= 16_000}
                );
        }

    }
}
