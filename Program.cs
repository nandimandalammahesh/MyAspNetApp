using Microsoft.EntityFrameworkCore;

using MyAspNetApp.Data;     // For ApplicationDbContext
using MyAspNetApp.Models;   // For FourMData


var builder = WebApplication.CreateBuilder(args);


// Add services
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddOpenApi();
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));


var app = builder.Build();

// Enable Swagger in dev
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

// Middleware
app.UseHttpsRedirection();

app.MapControllers(); // Register your APIs

app.Run();
