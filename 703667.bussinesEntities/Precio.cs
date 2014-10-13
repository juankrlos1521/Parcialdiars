using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _703667.bussinesEntities
{
    public class Precio
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public decimal Monto { get; set; }
        public bool Activo { get; set; }
        public string Comentario { get; set; }
        public byte rowVersion { get; set; }
        public int TipoPeliculaId { get; set; }
    }
}
