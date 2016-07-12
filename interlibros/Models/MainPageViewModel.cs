using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace interlibros.Models
{
    public class MainPageViewModel
    {
        
        public IEnumerable<Libros> libros;
        public IEnumerable<Libros> ResLibros;
        public IEnumerable<Librerias> librerias;
        public IEnumerable<Categorias> categorias;
    }
}