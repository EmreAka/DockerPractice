using Application;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<GreetingService>();

var app = builder.Build();

app.MapGet("/", (GreetingService service) => service.Greet("Emre"));

app.Run();