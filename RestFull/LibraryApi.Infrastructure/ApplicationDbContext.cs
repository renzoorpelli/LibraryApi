using LibraryApi.Domain.Enitities;
using Microsoft.EntityFrameworkCore;

namespace LibraryApi.Infrastructure
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Libro> Libros { get; private set; }
    }
}
