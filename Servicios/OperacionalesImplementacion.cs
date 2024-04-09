using Ejercicio1Global.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1Global.Servicios
{
    /// <summary>
    /// Clase que implementa a la interfaz de las operaciones de las bibliotecas
    /// irodhan -> 03/04/204
    /// </summary>
    internal class OperacionalesImplementacion : OperacionalesInterfaz
    {
        public void darAltaBiblioteca(List<BibliotecaDto> listaBibliotecasAntigua)
        {
            BibliotecaDto nuevaBiblioteca = crearBiblioteca();
            listaBibliotecasAntigua.Add(nuevaBiblioteca);
        }
        private BibliotecaDto crearBiblioteca() 
        { 
            BibliotecaDto biblioteca = new BibliotecaDto();
            Console.WriteLine("Introduzca el nombre de la biblioteca: ");
            biblioteca.NombreBiblioteca = Console.ReadLine();
            Console.WriteLine("Introduzca la direccion de la biblioteca: ");
            biblioteca.DireccionBiblioteca = Console.ReadLine();
            return biblioteca;
        }

        public void darAltaCliente(List<ClienteDto> listaClientesAntigua)
        {
            ClienteDto nuevoCliente = crearCliente();
            listaClientesAntigua.Add(nuevoCliente);
        }
        /// <summary>
        /// Metodo que pide la informacion necesaria de un nuevo cliente
        /// irodhan -> 08/04/2024
        /// </summary>
        /// <returns>Devuelve el objeto nuecoCliente con toda la informacion del nuevo usuario</returns>
        private ClienteDto crearCliente() 
        {
            ClienteDto nuevoCliente = new ClienteDto();
            Console.WriteLine("Introduzca el nombre del usuario: ");
            nuevoCliente.NombreCliente = Console.ReadLine();
            Console.WriteLine("Introduzca los apellidos del usuario: ");
            nuevoCliente.ApellidosCliente = Console.ReadLine();
            Console.WriteLine("Introduzca la fecha de nacimiento del usuario: ");
            nuevoCliente.FchNacimientoCliente = Console.ReadLine();
            Console.WriteLine("Introduzca el dani del usuario: ");
            nuevoCliente.DniCliente=Console.ReadLine();
            Console.WriteLine("Introduzca el email del usuario: ");
            nuevoCliente.EmailCliente = Console.ReadLine();
            return nuevoCliente;
        }

        public void darAltaLibro(List<LibroDto> listaLibrosAntigua)
        {
            LibroDto libro = crearLibro();
            listaLibrosAntigua.Add(libro);
        }
        /// <summary>
        /// Metodo que pide la informacion necesaria de un nuevo libro
        /// irodhan -> 08/04/2024
        /// </summary>
        /// <returns>Devuelve el objeto nuevo libro con toda la informacion obtenida</returns>
        private LibroDto crearLibro() 
        {
            LibroDto nuevoLibro = new LibroDto();
            Console.WriteLine("Introduzca el titulo del libro: ");
            nuevoLibro.TituloLibro = Console.ReadLine();
            Console.WriteLine("Introduzca el subtitulo del libro: ");
            nuevoLibro.SubtituloLibro = Console.ReadLine();
            Console.WriteLine("Introduzca el nombre del autor del libro: ");
            nuevoLibro.NombreAutorLibro = Console.ReadLine();
            Console.WriteLine("Introduzca el ISBN del libro: ");
            nuevoLibro.IsbnLibro = Console.ReadLine();
            Console.WriteLine("Introduzca el numero de edicion del libro: ");
            nuevoLibro.NumeroEdicion=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduzca la editorial del libro: ");
            nuevoLibro.EditorialLibro = Console.ReadLine();
            Console.WriteLine("Introduzca el stock del libro: ");
            nuevoLibro.StrockLibro=Convert.ToInt32(Console.ReadLine());
            return nuevoLibro;
        }

        public void darAltaPrestamo(List<PrestamoDto> listaPrestamos)
        {
            throw new NotImplementedException();
        }

   
    }
}
