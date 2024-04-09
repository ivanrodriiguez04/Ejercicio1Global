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
        long idBiblioteca;
        string nombreBiblioteca = "aaaaa";
        string direccionBiblioteca = "aaaaa";

       

        //Constructores
        public BibliotecaDto(long idBiblioteca,string nombreBiblioteca, string direccionBiblioteca)
        {
            this.IdBiblioteca=idBiblioteca;
            this.NombreBiblioteca = nombreBiblioteca;
            this.DireccionBiblioteca = direccionBiblioteca;
        }
        public BibliotecaDto()
        {
        }

        //Getters & Setters
        public long IdBiblioteca { get => idBiblioteca; set => idBiblioteca = value; }
        public string NombreBiblioteca { get => nombreBiblioteca; set => nombreBiblioteca = value; }
        public string DireccionBiblioteca { get => direccionBiblioteca; set => direccionBiblioteca = value; }

        

    }
}
