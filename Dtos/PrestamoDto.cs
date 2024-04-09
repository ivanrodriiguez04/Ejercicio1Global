using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1Global.Dtos
{
    /// <summary>
    /// Clase que contiene toda la informacion necesaria para realizar un prestamo
    /// irodhan -> 02/04/2024
    /// </summary>
    internal class PrestamoDto
    {
        //Atributos
        long idPrestamo;
        long idCliente;
        long idLibro;
        DateTime fchPrestamo=DateTime.Now.AddDays(1);
        DateTime fchEntrega=DateTime.Now.AddDays(7);
        string estadoPrestamo = "aaaaaa";

        //Getters & Setters
        public long IdPrestamo { get => idPrestamo; set => idPrestamo = value; }
        public long IdCliente { get => idCliente; set => idCliente = value; }
        public long IdLibro { get => idLibro; set => idLibro = value; }
        public DateTime FchPrestamo { get => fchPrestamo; set => fchPrestamo = value; }
        public DateTime FchEntrega { get => fchEntrega; set => fchEntrega = value; }
        public string EstadoPrestamo { get => estadoPrestamo; set => estadoPrestamo = value; }

        //Constructores
        public PrestamoDto()
        {
        }

        public PrestamoDto(long idPrestamo, long idCliente, long idLibro, DateTime fchPrestamo, DateTime fchEntrega, string estadoPrestamo)
        {
            this.idPrestamo = idPrestamo;
            this.idCliente = idCliente;
            this.idLibro = idLibro;
            this.fchPrestamo = fchPrestamo;
            this.fchEntrega = fchEntrega;
            this.estadoPrestamo = estadoPrestamo;
        }

    }
}
