using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation.Results;

namespace LibraryApi.Domain.Extension
{
    public static class ValidateExtension
    {
        /// <summary>
        /// metodo de extesion encargado de devolver en un diccionario toda la lista de errores
        /// </summary>
        /// <param name="result"></param>
        /// <returns></returns>
        public static Dictionary<string, string[]> ValidationErrors(this ValidationResult result)
        {
            return result.Errors
                .GroupBy(error => error.PropertyName, error=> error.ErrorMessage)
                .ToDictionary(errorGroup => errorGroup.Key, errorGruop => errorGruop.ToArray());
        }
    }
}
