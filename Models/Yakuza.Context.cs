﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Yakuza.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class YakuzaEntities : DbContext
    {
        public YakuzaEntities()
            : base("name=YakuzaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<Calificacion> Calificacion { get; set; }
        public virtual DbSet<Carrito> Carrito { get; set; }
        public virtual DbSet<CatalogoCarrito> CatalogoCarrito { get; set; }
        public virtual DbSet<CategoriaPlatillo> CategoriaPlatillo { get; set; }
        public virtual DbSet<Comentario> Comentario { get; set; }
        public virtual DbSet<Consumidor> Consumidor { get; set; }
        public virtual DbSet<Direccion> Direccion { get; set; }
        public virtual DbSet<Membresia> Membresia { get; set; }
        public virtual DbSet<Pais> Pais { get; set; }
        public virtual DbSet<Platillo> Platillo { get; set; }
        public virtual DbSet<Precio> Precio { get; set; }
        public virtual DbSet<Sucursal> Sucursal { get; set; }
        public virtual DbSet<Tarjeta> Tarjeta { get; set; }
        public virtual DbSet<TipoDeTarjeta> TipoDeTarjeta { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
    }
}
