using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductCatalogApi.Domain;

namespace ProductCatalogApi.Data.Configurations
{
    public class BrandConfiguration : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.ToTable("Brands");

            builder.Property(b => b.Name)
                   .IsRequired()
                   .HasMaxLength(256);

            builder.HasMany(b => b.Items)
                .WithOne(i => i.Brand);

        }
    }
}
