﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ST.Eg.EF.BreakAwayModel
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BreakAwayContext : DbContext
    {
        public BreakAwayContext()
            : base("name=BreakAwayContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<Activity> Activities { get; set; }
        public virtual DbSet<InternetSpecial> InternetSpecials { get; set; }
        public virtual DbSet<Lodging> Lodgings { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<Reservation> Reservations { get; set; }
        public virtual DbSet<Trip> Trips { get; set; }
    }
}
