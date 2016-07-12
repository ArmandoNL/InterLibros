using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace interlibros.Models
{
    public class LibreriaDetalleViewModel
    {
        public Librerias libreria;
        public IEnumerable<Libros> libros;
    }
}