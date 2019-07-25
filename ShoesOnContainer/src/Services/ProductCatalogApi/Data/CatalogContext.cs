using Microsoft.EntityFrameworkCore;
using ProductCatalogApi.Data.Configurations;
using ProductCatalogApi.Domain;

namespace ProductCatalogApi.Data
{
    public class CatalogContext : DbContext
    {
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Type> Types { get; set; }

        public CatalogContext(DbContextOptions options) 
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BrandConfiguration());
            modelBuilder.ApplyConfiguration(new ItemConfiguration());
            modelBuilder.ApplyConfiguration(new TypeConfiguration());
        }
    }
}
