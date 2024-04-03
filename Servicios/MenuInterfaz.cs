using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1Global.Servicios
{
    /// <summary>
    /// Interfaz de los menus de la aplicacion
    /// irodhan -> 03/04/2024
    /// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Metodo que muestra al usuario las opciones que tiene dentro de la aplicacion
        /// irodhan -> 03/04/2024
        /// </summary>
        /// <returns>Devuelve la opcion deseada por el usuario</returns>
        public int mostrarMenuYSeleccion();
    }
}
