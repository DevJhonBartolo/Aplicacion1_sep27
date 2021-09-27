
using Microsoft.EntityFrameworkCore;
using Aplicacion.App.Dominio;
namespace Aplicacion.App.Persistencia
{
    public class  AppContext:DbContext
    {
        public DbSet<Persona> Personas {get;set;}
        public DbSet<Estacion> Estaciones {get;set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                //optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog=aplicacion1db");
                //optionsBuilder.UseSqlServer("Data Source=(localDb)\\MSSQLLocalDB; Initial Catalog=aplicacion1");
                optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=Aplicacion1DB;Integrated Security=False;User ID=sa;Password=ingeniero2021;");
            }
        }
    }
}


