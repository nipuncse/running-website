﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Website.Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Juggle4Food_RunningEntities : DbContext
    {
        public Juggle4Food_RunningEntities()
            : base("name=Juggle4Food_RunningEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<RunningActivity> RunningActivities { get; set; }
        public virtual DbSet<RunningEvent> RunningEvents { get; set; }
        public virtual DbSet<RunningPerson> RunningPersons { get; set; }
        public virtual DbSet<RunningUnit> RunningUnits { get; set; }
    }
}