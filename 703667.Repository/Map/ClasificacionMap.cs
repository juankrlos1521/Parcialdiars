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
    public class ClasificacionMap:EntityTypeConfiguration<Clasificacion>
    {
        public ClasificacionMap()
        {
            //hasKey es clave primaria
            this.HasKey(c => c.Id);
            //is Required es requerido no permite valores nulos
            this.Property(c => c.Decripcion).HasMaxLength(200).IsRequired();
            //hasmaxlength para la longitud 
            this.Property(c => c.Comentario).HasMaxLength(200);
            // para el RowVersion
            this.Property(c => c.RowVersion).IsRowVersion().IsConcurrencyToken().HasColumnType("timestamp");
            // dale nombre a la tabla
            this.ToTable("Clasificacion");

        }
    }
}
