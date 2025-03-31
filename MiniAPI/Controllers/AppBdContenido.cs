using Microsoft.EntityFrameworkCore;
using MiniAPI.Modelo;

namespace MiniAPI.Datos
{
    public class AppBdContenido : DbContext
    {
        public AppBdContenido(DbContextOptions<AppBdContenido> options) : base(options) {}

        public DbSet<Producto> Productos { get; set; }
    }
}
