using Foots.API.Data;
using Foots.API.Data.Entities;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<FootsContext>();

var app = builder.Build();

app.MapGet("/api/products", (FootsContext ctx) => ctx.Products.ToList());

app.Run();
