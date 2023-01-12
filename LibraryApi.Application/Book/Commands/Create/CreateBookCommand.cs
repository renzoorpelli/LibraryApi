using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LibraryApi.Application.Book.Commands.Create
{
    public sealed record CreateBookCommand(string titulo, string autor, DateTime fechaPublicacion, string editorial); /*: ICommand<int>*/
}
