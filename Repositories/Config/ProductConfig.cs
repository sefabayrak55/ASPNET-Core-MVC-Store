using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.Config
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.ProductId);
            builder.Property(p => p.ProductName).IsRequired();
            builder.Property(p => p.ProductPrice).IsRequired();

            builder.HasData(
                    new Product() { ProductId = 1, CategoryId = 2, ProductName = "Computer", ProductPrice = 12_000 },
                    new Product() { ProductId = 2, CategoryId = 2, ProductName = "iPhone", ProductPrice = 13_000 },
                    new Product() { ProductId = 3, CategoryId = 2, ProductName = "Printer", ProductPrice = 14_000 },
                    new Product() { ProductId = 4, CategoryId = 2, ProductName = "Monitor", ProductPrice = 15_000 },
                    new Product() { ProductId = 5, CategoryId = 2, ProductName = "Keyboard", ProductPrice = 15_000 },
                    new Product() { ProductId = 6, CategoryId = 1, ProductName = "Phone", ProductPrice = 15_000 },
                    new Product() { ProductId = 7, CategoryId = 1, ProductName = "Charger", ProductPrice = 15_000 },
                    new Product() { ProductId = 8, CategoryId = 3, ProductName = "Bike", ProductPrice = 15_000 },
                    new Product() { ProductId = 9, CategoryId = 3, ProductName = "Bike Wheel", ProductPrice = 16_000 }
                );
        }
    }
}
