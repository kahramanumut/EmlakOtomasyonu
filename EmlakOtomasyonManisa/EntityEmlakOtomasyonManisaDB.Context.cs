﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EmlakOtomasyonManisa
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class EntityEmlakOtomasyonManisa : DbContext
    {
        public EntityEmlakOtomasyonManisa()
            : base("name=EntityEmlakOtomasyonManisa")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<cariler> cariler { get; set; }
        public DbSet<emlakTipiTablo> emlakTipiTablo { get; set; }
        public DbSet<evler> evler { get; set; }
        public DbSet<settings> settings { get; set; }
        public DbSet<sysdiagrams> sysdiagrams { get; set; }
        public DbSet<users> users { get; set; }
    }
}
