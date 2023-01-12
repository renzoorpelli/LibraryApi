using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApi.Application.Book.Queries.Get
{
    /// <summary>
    /// El tipo que devolvera IRequest<>
    /// </summary>
    public sealed class GetBooksQueryResponse
    {
        public int Id { get; set; }
        public string? Titulo { get; set; }
        public string? Autor { get; set; }
        public DateTime? FechaPublicacion { get; set; }
        public string? Editorial { get; set; }
    }
}
