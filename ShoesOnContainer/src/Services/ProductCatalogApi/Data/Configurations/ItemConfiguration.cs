using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductCatalogApi.Domain;

namespace ProductCatalogApi.Data.Configurations
{
    public class ItemConfiguration : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            builder.ToTable("Items");

            builder.Property(i => i.Name)
                   .IsRequired()
                   .HasMaxLength(256);

            builder.Property(i => i.Description)
                   .IsRequired()
                   .HasMaxLength(512);

            builder.Property(i => i.Price)
                   .HasColumnType("DECIMAL(29,2)");

            builder.Property(i => i.PictureFileName)
                   .IsRequired()
                   .HasMaxLength(512);

            builder.Property(i => i.PictureUrl)
                   .IsRequired()
                   .HasMaxLength(1024);

            builder.HasOne(i => i.Brand)
                   .WithMany(b => b.Items);

            builder.HasOne(i => i.Type)
                   .WithMany(t => t.Items);


        }
    }
}
