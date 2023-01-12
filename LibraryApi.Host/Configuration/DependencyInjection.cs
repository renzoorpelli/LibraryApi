using LibraryApi.Infrastructure;
using Microsoft.EntityFrameworkCore;
namespace LibraryApi.Host.Configuration
{
    /// <summary>
    /// Metodos de Extension de la Interfaz IServiceCollection con la finalidad de 
    /// Descoplar la clase Program.cs y encapsular todas las inyecciones de dependencia
    /// </summary>
    public static class DependencyInjection
    {
        /// <summary>
        /// metodo encargado de agregar el servicio de Oracle
        /// </summary>
        /// <param name="services">coleccion de servicios</param>
        /// <param name="configuration">configuracion de la aplicacion</param>
        /// <returns></returns>
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            string connectionString = configuration.GetConnectionString("OracleDB")!;

            services.AddDbContext<ApplicationDbContext>(options => {
                options.UseOracle(connectionString);
            });
            return services;
        }
    }
}
