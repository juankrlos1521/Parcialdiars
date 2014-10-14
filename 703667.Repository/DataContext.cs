using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;
using _703667.bussinesEntities;

namespace _703667.Repository
{
    public class DataContext:DbContext
    {
        public DataContext() 
        {
            Database.SetInitializer<DataContext>(new DropCreateDatabaseIfModelChanges<DataContext>());
        }

        public DbSet<Pelicula> Peliculas { get; set; }
        //clasificacionES goku
        public DbSet<Clasificacion> Clasificaciones { get; set; }
        public DbSet<Genero> Generos { get; set; }
        public DbSet<Precio> Precios { get; set; }
        public DbSet<TipoPelicula> TipoPeliculas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new PeliculaMap());
            modelBuilder.Configurations.Add(new ClasificacionMap());
            modelBuilder.Configurations.Add(new GeneroMap());
            modelBuilder.Configurations.Add(new PrecioMap());
            modelBuilder.Configurations.Add(new TipoPeliculaMap());
        }



    }
}
