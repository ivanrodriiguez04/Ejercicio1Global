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
        public void darAltaBiblioteca()
        {
            throw new NotImplementedException();
        }

        public void darAltaCliente()
        {
           
        }
        private ClienteDto crearCliente() 
        {
            ClienteDto nuevoCliente = new ClienteDto();
            Console.WriteLine("Introduzca el nombre del usuario: ");
            nuevoCliente.NombreCliente = Console.ReadLine();
            return nuevoCliente;
        }

        public void darAltaLibro()
        {
            throw new NotImplementedException();
        }

        public void darAltaPrestamo()
        {
            throw new NotImplementedException();
        }
    }
}
