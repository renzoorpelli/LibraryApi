using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryApi.Domain.Enitities
{
    public class Libro
    {
        public decimal Id { get; set; }

        public string? Titulo { get; set; }

        public string? Autor { get; set; }

        public DateTime? FechaPublicacion { get; set; }

        public string? Editorial { get; set; }
    }
}
