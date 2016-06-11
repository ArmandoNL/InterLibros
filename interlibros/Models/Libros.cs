//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
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
            this.LibroEnTransaccion = new HashSet<LibroEnTransaccion>();
            this.LibrosEnCarro = new HashSet<LibrosEnCarro>();
        }
    
        public int id { get; set; }
        public int idLibreria { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int Idioma { get; set; }
        public int Condicion { get; set; }
        public int Cantidad { get; set; }
        public string Description { get; set; }
        public int Descuento { get; set; }
        public int Precio { get; set; }
        public string NombreImagen { get; set; }
        public string ContentType { get; set; }
        public byte[] Imagen { get; set; }
    
        public virtual Libreria Libreria { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LibroEnTransaccion> LibroEnTransaccion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LibrosEnCarro> LibrosEnCarro { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}
