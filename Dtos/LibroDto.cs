using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1Global.Dtos
{
    /// <summary>
    /// Clase que contiene la informacion necesaria de los libros
    /// irodhan -> 02/04/2024
    /// </summary>
    internal class LibroDto
    {
        //Atributos
        string tituloLibro = "aaaaa";
        string subtituloLibro = "aaaaa";
        string nombreAutorLibro = "aaaaa";
        string isbnLibro = "aaaaa";
        int numeroEdicion = 0;
        string editorialLibro = "aaaaa";
        int strockLibro = 0;
        
        //Constructores
        public LibroDto(string tituloLibro, string subtituloLibro, string nombreAutorLibro, string isbnLibro, int numeroEdicion, string editorialLibro, int strockLibro)
        {
            this.tituloLibro = tituloLibro;
            this.subtituloLibro = subtituloLibro;
            this.nombreAutorLibro = nombreAutorLibro;
            this.isbnLibro = isbnLibro;
            this.numeroEdicion = numeroEdicion;
            this.editorialLibro = editorialLibro;
            this.strockLibro = strockLibro;
        }
        public LibroDto() 
        { 
        }

        //Getters & Setters
        public string TituloLibro { get => tituloLibro; set => tituloLibro = value; }
        public string SubtituloLibro { get => subtituloLibro; set => subtituloLibro = value; }
        public string NombreAutorLibro { get => nombreAutorLibro; set => nombreAutorLibro = value; }
        public string IsbnLibro { get => isbnLibro; set => isbnLibro = value; }
        public int NumeroEdicion { get => numeroEdicion; set => numeroEdicion = value; }
        public string EditorialLibro { get => editorialLibro; set => editorialLibro = value; }
        public int StrockLibro { get => strockLibro; set => strockLibro = value; }
    
    
    }
}
