using Microsoft.EntityFrameworkCore;

using EmployeeManagement.Data;
using EmployeeManagement.Interfaces;
using EmployeeManagement.Repositories;
using EmployeeManagement.Services;

var builder = WebApplication.CreateBuilder(args);

// Register Controllers
builder.Services.AddControllers();

// Register Database
builder.Services.AddDbContext<EmployeeDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection")
    )
);

// Register Repository
builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();

// Register Service
builder.Services.AddScoped<IEmployeeService, EmployeeService>();

// OpenAPI
builder.Services.AddOpenApi();

var app = builder.Build();

// HTTP Pipeline
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();