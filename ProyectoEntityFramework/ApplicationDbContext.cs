using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProyectoEntityFramework.Entity;

namespace ProyectoEntityFramework
{
    public class ApplicationDBContext : IdentityDbContext
    {
        public ApplicationDBContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Tarea> Tareas { get; set; }    

        public DbSet<Paso> Paso { get; set; }   

        public DbSet<ArchivoAdjunto> ArchivosAdjuntos { get; set; }
    }
}
