using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _703667.bussinesEntities
{
   public class Pelicula
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Sinopsis { get; set; }
        public int DuracionMin { get; set; }
        public string Pais { get; set; }
        public byte[] Cartel { get; set; }
        public string Director { get; set; }
        public string Actores { get; set; }
        public string SitioWeb { get; set; }
        public bool Activo { get; set; }
        public byte[] RowVersion { get; set; }


        public int ClasificacionId { get; set; }
        public int GeneroId { get; set; }
        public int TipoPeliculaId { get; set; }


        public Clasificacion Clasificacion { get; set; }
        public Genero Genero { get; set; }
        public TipoPelicula TipoPelicula { get; set; }
    }
}
