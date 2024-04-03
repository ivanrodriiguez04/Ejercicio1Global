using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1Global.Dtos
{
    /// <summary>
    /// Clase que contiene la informacion necesaria del cliente
    /// irodhan -> 01/04/2024
    /// </summary>
    internal class ClienteDto
    {
        //Atributos
        string nombreCliente = "aaaaa";
        string apellidosCliente = "aaaaa";
        string fchNacimientoCliente = "31/12/9999";
        string DNICliente = "11111111A";
        string emailCliente = "aaaaa";
        DateTime fchInicioSuspension= DateTime.Now;
        DateTime fchFinSuspension= DateTime.Now;
        //Constructores
        public ClienteDto(string nombreCliente, string apellidosCliente, string fchNacimientoCliente, string dNICliente, string emailCliente, DateTime fchInicioSuspension, DateTime fchFinSuspension)
        {
            this.NombreCliente = nombreCliente;
            this.ApellidosCliente = apellidosCliente;
            this.FchNacimientoCliente = fchNacimientoCliente;
            this.DNICliente1 = dNICliente;
            this.EmailCliente = emailCliente;
            this.FchInicioSuspension = fchInicioSuspension;
            this.FchFinSuspension = fchFinSuspension;
        }
        //Getters & Setters
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public string ApellidosCliente { get => apellidosCliente; set => apellidosCliente = value; }
        public string FchNacimientoCliente { get => fchNacimientoCliente; set => fchNacimientoCliente = value; }
        public string DNICliente1 { get => DNICliente; set => DNICliente = value; }
        public string EmailCliente { get => emailCliente; set => emailCliente = value; }
        public DateTime FchInicioSuspension { get => fchInicioSuspension; set => fchInicioSuspension = value; }
        public DateTime FchFinSuspension { get => fchFinSuspension; set => fchFinSuspension = value; }
    }
}
