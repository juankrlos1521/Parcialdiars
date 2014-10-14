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
    class PrecioMap:EntityTypeConfiguration<Precio>
    {
        public PrecioMap() 
        {
            this.HasKey(r => r.Id);
            this.Property(r => r.Descripcion).HasMaxLength(200).IsRequired();
            //hasprecision para decimal 9,2 segun el diagrama de base de datos
            this.Property(r => r.Monto).HasPrecision(9, 2);
            this.Property(r => r.Comentario).HasMaxLength(200);
            this.Property(r => r.rowVersion).IsRowVersion().IsConcurrencyToken().HasColumnType("timestamp");

            this.HasRequired(p => p.TipoPelicula).WithMany(tp => tp.PreciosList).HasForeignKey(p => p.TipoPeliculaId).WillCascadeOnDelete(false);

            this.ToTable("Precio");
        }
    }
}
