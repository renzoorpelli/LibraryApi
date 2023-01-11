using LibraryApi.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System.Drawing;

namespace LibraryApi.Host.Configuration
{
    /// <summary>
    /// Metodos de Extension de la Interfaz IServiceCollection con la finalidad de 
    /// Descoplar la clase Program.cs y encapsular todas las inyecciones de dependencia
    /// </summary>
    public static class DependencyInjection
    {
        public static IServiceCollection AddOracleContext(this IServiceCollection services, IConfiguration configuration)
        {
            string connectionString = configuration.GetConnectionString("OracleDB")!;

            services.AddDbContext<ApplicationDbContext>(options => {
                options.UseOracle(connectionString);
            });
            return services;
        }
    }
}
