using Foots.API.Data;
using Microsoft.EntityFrameworkCore;
using WilderMinds.MinimalApiDiscovery;
using static Microsoft.AspNetCore.Http.Results;

namespace Foots.API.Apis;

public class ProductApi : IApi
{
  public void Register(IEndpointRouteBuilder app)
  {
    var group = app.MapGroup("/api/products");

    group.MapGet("", GetProducts);
    group.MapGet("{id:int}", GetProduct);
  }

  private async Task<IResult> GetProduct(FootsContext ctx, int id)
  {
    var product = await ctx.Products
      .Include(p => p.Category)
      .Where(p => p.Id == id)
      .FirstOrDefaultAsync();

    if (product is null) return NotFound();
    return Ok(product);
  }

  private async Task<IResult> GetProducts(FootsContext ctx, string style = "")
  {
    if (style == "brief")
    {
      return Ok(await ctx.Products
        .Include(p => p.Category)
        .Select(p => new
        {
          p.Id,
          p.Title,
          p.ImageUrl,
          Category = p.Category != null ? p.Category.Name : ""
        })
        .ToListAsync());
    }

    return Ok(await ctx.Products
      .Include(p => p.Category)
      .ToListAsync());
  }
}
