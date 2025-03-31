using Microsoft.EntityFrameworkCore;
using MiniAPI.Datos;

var builder = WebApplication.CreateBuilder(args);

// 👉 Conexión a base de datos SQL Server
builder.Services.AddDbContext<AppBdContenido>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// 👉 Servicios de la API
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// 👉 Middleware para desarrollo (Swagger)
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
