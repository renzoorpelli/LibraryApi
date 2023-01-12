using LibraryApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApi.Infrastructure.Persistence.Repositories
{
    public sealed class BooksRepository
    {
        private readonly ApplicationDbContext _context;

        public BooksRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// metodo encargado de agregar una nueva entidad a la tabla de la base de datos correspondiente
        /// </summary>
        /// <param name="libro"></param>
        public void Add(Libro libro)
        {
            this._context.Set<Libro>().Add(libro); 
        }
    }
}
