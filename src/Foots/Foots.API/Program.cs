using Foots.API.Apis;
using Foots.API.Data;
using Foots.API.Data.Entities;
using Microsoft.EntityFrameworkCore;
using WilderMinds.MinimalApiDiscovery;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<FootsContext>();

var app = builder.Build();

app.MapApis();

//new ProductApi().Register(app);
//app.MapGet("/api/products", (FootsContext ctx) => ctx.Products.ToList());

app.Run();
