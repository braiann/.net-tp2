﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Academia.Data.Database
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class EntidadesTP2 : DbContext
    {
        public EntidadesTP2() : base("name=EntidadesTP2")
        {
            //this.Configuration.LazyLoadingEnabled = false;
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<alumnos_inscripciones> alumnos_inscripciones { get; set; }
        public virtual DbSet<comisiones> comisiones { get; set; }
        public virtual DbSet<cursos> cursos { get; set; }
        public virtual DbSet<docentes_cursos> docentes_cursos { get; set; }
        public virtual DbSet<especialidades> especialidades { get; set; }
        public virtual DbSet<materias> materias { get; set; }
        public virtual DbSet<modulos> modulos { get; set; }
        public virtual DbSet<modulos_usuarios> modulos_usuarios { get; set; }
        public virtual DbSet<personas> personas { get; set; }
        public virtual DbSet<planes> planes { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<usuarios> usuarios { get; set; }
    }
}
