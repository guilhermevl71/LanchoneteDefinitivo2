using LanchoneteDefinitivo.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi

var LanchoneteConnection = builder.Configuration.GetConnectionString("LanchoneteConnection");
builder.Services.AddDbContext<LanchoneteContext>(opts => opts.UseMySql(LanchoneteConnection, ServerVersion.AutoDetect(LanchoneteConnection)));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
