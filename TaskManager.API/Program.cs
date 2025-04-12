using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using TaskManager.Infrastructure.Persistence;
using TaskManager.Domain.Repositories;
using TaskManager.Infrastructure.Repositories;
using TaskManager.Application.Services;

var builder = WebApplication.CreateBuilder(args);

// Swagger tradicional
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddControllers();

// Banco de dados SQLite
builder.Services.AddDbContext<TaskDbContext>(options =>
    options.UseSqlite("Data Source=taskmanager.db"));

// Injeção de dependência
builder.Services.AddScoped<ITaskRepository, TaskRepository>();
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<TaskService>();
builder.Services.AddScoped<CategoryService>();



var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
