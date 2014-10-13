using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _703667.bussinesEntities
{
    public class Clasificacion
    {
        public int Id { get; set; }
        public string Decripcion { get; set; }
        public string Comentario { get; set; }
        public byte RowVersion { get; set; }
    }
}
