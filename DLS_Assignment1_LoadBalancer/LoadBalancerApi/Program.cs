using LoadBalancerApi.Data;
using LoadBalancerApi.Data.DbInitializer;
using LoadBalancerApi.Data.Repo;
using LoadBalancerApi.LoadBalancer;
using LoadBalancerApi.LoadBalancerStrategy;
using LoadBalancerApi.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<ApiServiceContext>(opt => opt.UseInMemoryDatabase("ApiServicesDb"));

// Register repositories and services for dependency injection
builder.Services.AddScoped<IRepository<ApiService>, ServicesRepository>();
builder.Services.AddTransient<ILoadBalancer, LoadBalancer>();
builder.Services.AddTransient<ILoadBalancerStrategy, LoadBalancerStrategy>();

// Register database initializer for dependency injection
builder.Services.AddTransient<IDbInitializer, DbInitializer>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Initialize the database.
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var dbContext = services.GetService<ApiServiceContext>();
    var dbInitializer = services.GetService<IDbInitializer>();
    dbInitializer.Initialize(dbContext);
}

app.UseAuthorization();

app.MapControllers();

app.Run();
