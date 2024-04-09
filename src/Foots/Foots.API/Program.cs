var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/api/message/{id}", (int id) => new { id, message = "Hello World" });

app.Run();
