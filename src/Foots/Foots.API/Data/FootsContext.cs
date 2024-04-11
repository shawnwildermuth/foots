using System.Text.Json;
using Foots.API.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Foots.API.Data;

public class FootsContext(IConfiguration configuration) : DbContext
{
  public DbSet<Product> Products => Set<Product>();
  public DbSet<Category> Categories => Set<Category>();
  public DbSet<Cart> Carts => Set<Cart>();

  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
  {
    optionsBuilder.UseSqlServer(configuration.GetConnectionString("CatalogDb"));
  }

  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    base.OnModelCreating(modelBuilder);

    modelBuilder.Entity<Product>()
      .Property(p => p.Price)
      .HasColumnType("decimal(9,2)");

    var products = SeedData.GetProducts();
    var categories = SeedData.GetCategories();

    modelBuilder.Entity<Category>()
      .HasData(categories);

    modelBuilder.Entity<Product>()
      .HasData(products);

  }
}
