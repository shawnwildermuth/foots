using Foots.API.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<CatalogContext>();

var app = builder.Build();

app.MapGet("/api/message/{id}", (int id) => new { id, message = "Hello World" });

app.Run();
