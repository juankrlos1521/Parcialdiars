using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



using _703667.bussinesEntities;
using _703667.Repository;

namespace _703667.CrearDataBase
{
    public class Program
    {
        static void Main(string[] args)
        {
            IGeneroRepository _rep = new GeneroRepository();

            var genero = new Genero()
            {
                Id = 1,
                Descripcion = "Hola",
                Comentario = "Mundo",

            };


            var genero2 = new Genero()
            {
                Id = 2,
                Descripcion = "hello",
                Comentario = "bitch",

            };

            Console.WriteLine("Intentando Crear DataBase");
            _rep.Addgenero(genero);
            _rep.Addgenero(genero2);
            Console.WriteLine("Felicidades  si se creo DataBase Created");
            Console.ReadLine();

        }
    }
}
