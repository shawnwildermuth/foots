using System;
using System.IO;
using System.Text.Json;

var root = @"\projects\foots\resources\";

var options = new JsonSerializerOptions()
{
  PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
  WriteIndented = true
};

var json = File.ReadAllText($"{root}footware.json");
var products = JsonSerializer.Deserialize<Product[]>(json, options);

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
    
    realizedProducts.Add(product with { CategoryId = category!.Id}); 
  }


  var catJson = JsonSerializer.Serialize(uniqueCategories, options);
  var productJson = JsonSerializer.Serialize(realizedProducts, options);

  File.WriteAllText($"{root}categories.json", catJson);
  File.WriteAllText($"{root}products.json", productJson);
}

record Category(int Id, string Name);

record Product(
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

