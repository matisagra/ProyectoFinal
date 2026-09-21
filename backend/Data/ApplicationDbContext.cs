using Microsoft.EntityFrameworkCore;

namespace ProyectoFinal.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        // Aquí va los  DbSet para cada tabla por ejemplo:
        // public DbSet<Producto> Productos { get; set; }
    }
}