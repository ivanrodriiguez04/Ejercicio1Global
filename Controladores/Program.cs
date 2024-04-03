using Ejercicio1Global.Servicios;

namespace Ejercicio1Global.Controladores
{
    /// <summary>
    /// Clase principal de la aplcacion
    /// irodhan -> 01/04/2024
    /// </summary>
    class Program
    {
        /// <summary>
        /// Metodo principal de la aplicacion
        /// irodhan -> 01/04/2024
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Objetos
            MenuInterfaz mI = new MenuImplementacion();
            OperacionalesInterfaz oI=new OperacionalesImplementacion();
            //Atributos
            int opcionSeleccionada = 0;
            bool cerrarMenu=false;

            try 
            {
                opcionSeleccionada = mI.mostrarMenuYSeleccion();

                switch (opcionSeleccionada) 
                { 
                    case 0:
                        Console.WriteLine("[INFO] - Ha seleccionado la opcion 0");
                        Console.WriteLine("[INFO] - La aplicación va a cerrarse");
                        cerrarMenu = true;
                        break;
                    case 1:
                        Console.WriteLine("[INFO] - Ha seleccionado la opcion 1");
                        oI.darAltaBiblioteca();
                        break;
                    case 2:
                        Console.WriteLine("[INFO] - Ha seleccionado la opcion 0");
                        oI.darAltaCliente();
                        break;
                    case 3:
                        Console.WriteLine("[INFO] - Ha seleccionado la opcion 0");
                        oI.darAltaLibro();
                        break;
                    case 4:
                        Console.WriteLine("[INFO] - Ha seleccionado la opcion 0");
                        oI.darAltaPrestamo();
                        break;
                    default:
                        Console.WriteLine("[INFO] - La opcion seleccionada no coincide con ninguna opcion mostrada anteriormente");
                        break;
                }
            } 
            catch (IOException e) 
            {
                Console.WriteLine("Error al leer o escribir en el archivo: " + e.Message);
            }
        }
    }
}
