//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace interlibros.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Libros
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Libros()
        {
            this.Categorias = new HashSet<Categorias>();
            this.LibroEnCarro = new HashSet<LibroEnCarro>();
            this.LibroEnTransaccion = new HashSet<LibroEnTransaccion>();
        }
    
        public int id { get; set; }
        public int idLibreria { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int Idioma { get; set; }
        public int Condicion { get; set; }
        public int Cantidad { get; set; }
        public int Descuento { get; set; }
        public int Precio { get; set; }
        public string ImgUrl { get; set; }
        public string Descripcion { get; set; }
    
        public virtual Librerias Librerias { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Categorias> Categorias { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LibroEnCarro> LibroEnCarro { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LibroEnTransaccion> LibroEnTransaccion { get; set; }
    }
}
