﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TechnoBackend.DatabaseModel
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DBModelContainer : DbContext
    {
        public DBModelContainer()
            : base("name=DBModelContainer")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<HAND_GEB> HAND_GEB { get; set; }
        public virtual DbSet<PRODs> PRODs { get; set; }
        public virtual DbSet<HAND_SUB_GEB_PROD> HAND_SUB_GEB_PROD { get; set; }
        public virtual DbSet<SUB_GEB> SUB_GEB { get; set; }
        public virtual DbSet<REVs> REVs { get; set; }
        public virtual DbSet<USERs> USERs { get; set; }
        public virtual DbSet<CATs> CATs { get; set; }
        public virtual DbSet<CAT_PROD> CAT_PROD { get; set; }
        public virtual DbSet<SESSIONS> SESSIONS { get; set; }
        public virtual DbSet<TAGS> TAGS { get; set; }
        public virtual DbSet<PRODTAGS> PRODTAGS { get; set; }
    }
}
