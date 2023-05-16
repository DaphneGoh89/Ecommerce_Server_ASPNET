using Ecommerce_Server.Configurations;
using Ecommerce_Server.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<EcommerceDbContext>(o => o.UseNpgsql(builder.Configuration.GetConnectionString("Postgres_Db")));
builder.Services.AddAutoMapper(typeof(MapperConfig));
builder.Services.AddControllers();


var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();

