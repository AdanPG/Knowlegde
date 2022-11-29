using Microsoft.EntityFrameworkCore;

namespace Recetas.Models
{
    public class myDbContext: DbContext
    {
        public myDbContext(DbContextOptions<myDbContext> options) : base(options)
        {

        }

        public DbSet<Tipo> Tipo { get; set; }

        public DbSet<Receta> Receta { get; set; }

    }
}
