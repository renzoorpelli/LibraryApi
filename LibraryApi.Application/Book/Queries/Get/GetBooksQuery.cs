using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace LibraryApi.Application.Book.Queries.Get
{
    /// <summary>
    /// El mediador tomará IRequest<> y se lo enviará a los handlers registrados, estos ya saben el 
    /// mensaje que recibiran y como proceder con la tarea
    /// </summary>
    public class GetBooksQuery : IRequest<List<GetBooksQueryResponse>>
    {
    }
}
