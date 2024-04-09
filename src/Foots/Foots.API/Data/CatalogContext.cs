using Foots.API.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Foots.API.Data;

public class CatalogContext(IConfiguration configuration) : DbContext
{
  public DbSet<Product> Products => Set<Product>();
  public DbSet<Category> Categories => Set<Category>();

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

    var options = new JsonSerializerOptions()
    {
      PropertyNameCaseInsensitive = true
    };

    var categoryJson = File.ReadAllText("categories.json");
    var categories = JsonSerializer.Deserialize<Category[]>(categoryJson, options);

    var productJson = File.ReadAllText("products.json");
    var products = JsonSerializer.Deserialize<Product[]>(productJson, options);

    modelBuilder.Entity<Category>()
      .HasData(categories!);

    modelBuilder.Entity<Product>()
      .HasData(products!);

  }
}
