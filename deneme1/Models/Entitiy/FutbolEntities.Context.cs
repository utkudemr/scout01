﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace deneme1.Models.Entitiy
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class FutbolEntity : DbContext
    {
        public FutbolEntity()
            : base("name=FutbolEntity")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Ligler> Ligler { get; set; }
        public virtual DbSet<Makale> Makale { get; set; }
        public virtual DbSet<Sporcu> Sporcu { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Takim> Takim { get; set; }
        public virtual DbSet<FizikselOzellikler> FizikselOzellikler { get; set; }
        public virtual DbSet<MentalOzellikler> MentalOzellikler { get; set; }
        public virtual DbSet<TaktikselOzellikler> TaktikselOzellikler { get; set; }
    }
}