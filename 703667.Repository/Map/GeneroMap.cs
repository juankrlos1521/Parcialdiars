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
    public class GeneroMap : EntityTypeConfiguration<Genero>
    {
        public GeneroMap() 
        {
            this.HasKey(g => g.Id);
            this.Property(g => g.Descripcion).HasMaxLength(200).IsRequired();
            this.Property(g => g.Comentario).HasMaxLength(200);
            this.Property(g => g.RowVersion).IsRowVersion().IsConcurrencyToken().HasColumnType("timestamp");

            this.ToTable("Genero");
        }
    }
}
