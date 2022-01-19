using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineStore.Domain.Core.Entities;

namespace OnlineStore.Infrastructure.Data.Configurations
{
    class ProductsConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasOne(product => product.Category)
                .WithMany(category => category.Products)
                .HasForeignKey(d => d.CategoryId);
            builder.Property(p => p.Price).HasPrecision(10, 3);
        }
    }
}
