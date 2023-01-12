using Carter;
using LibraryApi.Application.Book.Queries.Get;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace LibraryApi.Presentation.Books
{
    public class BooksModule : ICarterModule
    {
        //// base() : establezco la ruta base para el modulo de libros
        //public BooksModule() : base("/books")
        //{

        //}

        /// <summary>
        /// Metodo encargado de extender el enrutamiento de los endpoint, con el fin de organizar 
        /// y mantener la arquitectura limpia
        /// </summary>
        /// <param name="app">referencia a var builder del la clase Program.cs</param>
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapGet("/books",  async (ISender sender, CancellationToken cancellationToken) =>
            {
                var query = new GetBooksQuery();
                 List<GetBooksQueryResponse> lista = await sender.Send(query, cancellationToken);
                return lista;
            });

            //app.MapPost("/books", async CreateBookRequest request, ISender seder) => {

            //    CreateBookCommand command = request.Adapt<CreateBookCommand>();

            //    await semder.Send(command);

            //    return Results.Created();

            //});
        }
    }
}