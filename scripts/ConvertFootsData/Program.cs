using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

var root = @"\projects\foots\resources\";

var options = new JsonSerializerOptions()
{
  PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
  WriteIndented = true
};

var json = File.ReadAllText($"{root}footware.json");
var products = JsonSerializer.Deserialize<ProductImport[]>(json, options);

if (products is not null)
{
  int id = 0;
  // Get unit categories
  var uniqueCategories = products
      .DistinctBy(p => p.Subcategory)
      .Select(g => new Category(++id, g.Subcategory))
      .ToList();

  var realizedProducts = new List<Product>();

  foreach (var product in products!)
  {
    Category category = uniqueCategories!
      .Where(c => c.Name == product.Subcategory)
      .First();

    realizedProducts.Add(new Product(product with
    {
      CategoryId = category!.Id
    }));
  }


  var catJson = JsonSerializer.Serialize(uniqueCategories, options);
  var productJson = JsonSerializer.Serialize(realizedProducts, options);

  File.WriteAllText($"{root}categories.json", catJson);
  File.WriteAllText($"{root}products.json", productJson);
}

record Category(int Id, string Name);

class Product
{
  public Product() {}

  public Product(ProductImport import)
  {
    Id = import.ProductId;
    Gender = import.Gender;
    Description = import.Description;
    CategoryId = import.CategoryId;
    ImageFile = import.ImageFile;
    ImageUrl = import.ImageUrl;
    Type = import.Type;
    Color = import.Color;
    Usage = import.Usage;
    Price = (Random.Shared.Next(0, 60 * 2) * .5m) + 20m;
  }

  public int Id { get; init; }
  public string? Gender { get; init; }
  public int CategoryId { get; init; }
  public string? Type { get; init; }
  public string? Color { get; init; }
  public string? Usage { get; init; }
  public string? Description { get; init; }
  public string? ImageFile { get; init; }
  public string? ImageUrl { get; init; }
  public decimal Price { get; init; }

}


record ProductImport(
    int ProductId,
    string Gender,
    int CategoryId,
    string Category,
    string Subcategory,
    string Type,
    string Color,
    string Usage,
    string Description,
    string ImageFile,
    string ImageUrl
);

