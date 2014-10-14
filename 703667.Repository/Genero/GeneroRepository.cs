using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using _703667.bussinesEntities;

namespace _703667.Repository
{
    public class GeneroRepository:IGeneroRepository
    {

        private readonly DataContext _context;

        public GeneroRepository() 
        {
            if (_context == null) 
            {
                _context = new DataContext();
            }

        }

        public void Addgenero(Genero genero)
        {
            //generoS goku
            _context.Generos.Add(genero);
            _context.SaveChanges();
        }
    }
}
