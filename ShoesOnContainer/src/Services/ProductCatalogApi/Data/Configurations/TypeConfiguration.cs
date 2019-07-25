using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductCatalogApi.Domain;

namespace ProductCatalogApi.Data.Configurations
{
    public class TypeConfiguration : IEntityTypeConfiguration<Type>
    {
        public void Configure(EntityTypeBuilder<Type> builder)
        {
            builder.ToTable("Types");

            builder.Property(t => t.Name)
                   .IsRequired()
                   .HasMaxLength(256);

            builder.HasMany(t => t.Items)
                .WithOne(i => i.Type);
        }
    }
}
