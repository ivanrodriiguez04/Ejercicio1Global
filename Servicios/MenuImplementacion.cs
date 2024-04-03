using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1Global.Servicios
{
    /// <summary>
    /// Clase que implementa a la interfaz de los menus
    /// irodhan -> 03/04/2024
    /// </summary>
    internal class MenuImplementacion : MenuInterfaz
    {
        public int mostrarMenuYSeleccion()
        {
            Console.WriteLine("|------------------------------|");
            Console.WriteLine("|              Menú            |");
            Console.WriteLine("|______________________________|");
            Console.WriteLine("| 0. Cerrar aplicacion         |");
            Console.WriteLine("| 1. Dar alta nueva biblioteca |");
            Console.WriteLine("| 2. Dar alta nuevo cliente    |");
            Console.WriteLine("| 3. Dar alta nuevo libro      |");
            Console.WriteLine("| 4. Dar alta nuevo prestamo   |");
            Console.WriteLine("|______________________________|");
            Console.WriteLine("\nIntroduzca la opcion deseada:");
            int opcion = Console.ReadKey(true).KeyChar - ('0');
            return opcion;
        }
    }
}
