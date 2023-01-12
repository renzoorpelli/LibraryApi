using System.Reflection;

namespace LibraryApi.Application
{
    public static class AssemblyReference
    {
        /// <summary>
        /// Obtengo la referencia al ensamblado para MediaTR
        /// </summary>
        public static readonly Assembly GetAssembly = typeof(AssemblyReference).Assembly;
    }
}