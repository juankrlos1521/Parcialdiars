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
    class TipoPeliculaMap:EntityTypeConfiguration<TipoPelicula>
    {
        public TipoPeliculaMap() 
        {
            this.HasKey(t => t.Id);
            this.Property(t => t.Descripcion).HasMaxLength(200).IsRequired();
            this.Property(t => t.Comentario).HasMaxLength(200);

            this.Property(t => t.RowVersion).IsRowVersion().IsConcurrencyToken().HasColumnType("timestamp");

            this.ToTable("TipoPeliculas");
        }
    }
}
