using LibraryApi.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using MediatR;
using Carter;

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
        public static IServiceCollection AddInfrastructureLayer(this IServiceCollection services, IConfiguration configuration)
        {
            string connectionString = configuration.GetConnectionString("OracleDB")!;

            services.AddDbContext<ApplicationDbContext>(options => {
                options.UseOracle(connectionString);
            });
            return services;
        }

        /// <summary>
        /// metodo de extension encargado de agregar la capa de Application
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddApplicationLayer(this IServiceCollection services)
        {
            // agrego el connection factory
            services.AddScoped<IOracleConnectionFactory, OracleConnectionFactory>();

            //obtengo referencia al ensamblado de la capa Application
            var applicationAssembly = LibraryApi.Application.AssemblyReference.GetAssembly;

            services.AddMediatR(applicationAssembly);

            return services;
        }
        /// <summary>
        /// metodo encargado de agregar el servicio de Carter, el cual su implementacion se encuentra en la capa Presentation
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddPresentationLayer(this IServiceCollection services)
        {
            services.AddCarter();
            return services;
        }
    }
}
