using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1Global.Dtos
{
    /// <summary>
    /// Clase que contiene la informacion necesaria de las bibliotecas
    /// irodhan -> 01/04/2024
    /// </summary>
    internal class BibliotecaDto
    {
        //Atributos
        string nombreBiblioteca = "aaaaa";
        string direccionBiblioteca = "aaaaa";

       

        //Constructores
        public BibliotecaDto(string nombreBiblioteca, string direccionBiblioteca)
        {
            this.NombreBiblioteca = nombreBiblioteca;
            this.DireccionBiblioteca = direccionBiblioteca;
        }
        public BibliotecaDto()
        {
        }

        //Getters & Setters
        public string NombreBiblioteca { get => nombreBiblioteca; set => nombreBiblioteca = value; }
        public string DireccionBiblioteca { get => direccionBiblioteca; set => direccionBiblioteca = value; }

        

    }
}
