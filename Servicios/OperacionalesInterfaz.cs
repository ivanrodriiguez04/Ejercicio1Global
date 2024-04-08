using Ejercicio1Global.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1Global.Servicios
{
    /// <summary>
    /// Interfaz de las operaciones de las bibliotecas
    /// irodhan -> 03/04/2024
    /// </summary>
    internal interface OperacionalesInterfaz
    {
        /// <summary>
        /// Metodo que da el alta a una nueva biblioteca
        /// irodhan -> 03/04/2024
        /// </summary>
        public void darAltaBiblioteca(List<BibliotecaDto> listaBibliotecasAntigua);
        /// <summary>
        /// Metodo que da el alta a un nuevo cliente
        /// irodhan -> 03/04/2024
        /// </summary>
        public void darAltaCliente(List<ClienteDto> listaClientesAntigua);
        /// <summary>
        /// Metodo que da el alta a un nuevo libro
        /// irodhan -> 03/04/2024
        /// </summary>
        public void darAltaLibro(List<LibroDto> listaLibrosAntigua);
        /// <summary>
        /// Metodo que da el alta a un nuevo prestamo
        /// irodhan -> 03/04/2024
        /// </summary>
        public void darAltaPrestamo(List<PrestamoDto> listaPrestamosAntigua);
    }
}
