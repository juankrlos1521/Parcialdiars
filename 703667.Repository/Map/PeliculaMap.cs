using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using _703667.bussinesEntities;

namespace _703667.Repository
{
    public class PeliculaMap : EntityTypeConfiguration<Pelicula>
    {
        public PeliculaMap() 
        {
            this.HasKey(p => p.Id);
            this.Property(p => p.Titulo).HasMaxLength(200).IsRequired();
            this.Property(p => p.Sinopsis).HasMaxLength(200).IsRequired();
            this.Property(p => p.Pais).HasMaxLength(200).IsRequired();

            this.Property(p => p.Cartel).HasColumnType("image");

            this.Property(p => p.Director).HasMaxLength(200).IsRequired();
            this.Property(p => p.Actores).HasMaxLength(200).IsRequired();
            this.Property(p => p.SitioWeb).HasMaxLength(200).IsRequired();
            
            this.Property(p => p.RowVersion).IsRowVersion().IsConcurrencyToken().HasColumnType("timestamp");

            //para las claves foraneas
            this.HasRequired(p => p.Clasificacion).WithMany(c => c.PeliculasList).HasForeignKey(p => p.ClasificacionId).WillCascadeOnDelete(false);
            this.HasRequired(p => p.Genero).WithMany(g => g.PeliculasList).HasForeignKey(p => p.GeneroId).WillCascadeOnDelete(false);
            this.HasRequired(p => p.TipoPelicula).WithMany(tp => tp.PeliculasList).HasForeignKey(p => p.TipoPeliculaId).WillCascadeOnDelete(false);



            this.ToTable("Peliculaxxx");

            

        }
    }
}
