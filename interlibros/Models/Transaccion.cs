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
    
    public partial class Transaccion
    {
        public int id { get; set; }
        public int idUsuario { get; set; }
        public int idLibreria { get; set; }
        public System.DateTime Fecha { get; set; }
    
        public virtual Libreria Libreria { get; set; }
        public virtual LibroEnTransaccion LibroEnTransaccion { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}