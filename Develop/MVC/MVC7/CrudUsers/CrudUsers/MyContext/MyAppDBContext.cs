using CrudUsers.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudUsers.MyContext
{
    public class MyAppDBContext:DbContext
    {
        //1 se crea el constructor
        public MyAppDBContext(DbContextOptions<MyAppDBContext> Options) : base(Options)
        {

        }



        //aqui se referencian los modelos para que funcionen las migraciones
        public DbSet<Contacto> Contactos { get; set; }
    }
}
