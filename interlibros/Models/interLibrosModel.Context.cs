﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class interlibrosEntities : DbContext
    {
        public interlibrosEntities()
            : base("name=interlibrosEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Libros> Libros { get; set; }
        public virtual DbSet<Transacciones> Transacciones { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }
        public virtual DbSet<Librerias> Librerias { get; set; }
        public virtual DbSet<Categorias> Categorias { get; set; }
        public virtual DbSet<LibroEnCarro> LibroEnCarro { get; set; }
        public virtual DbSet<LibroEnTransaccion> LibroEnTransaccion { get; set; }
    }
}
