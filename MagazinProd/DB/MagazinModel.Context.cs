﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MagazinProd.DB
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MagazinEntities : DbContext
    {
        public MagazinEntities()
            : base("name=MagazinEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Materials> Materials { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<Repair> Repair { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Telephones> Telephones { get; set; }
        public virtual DbSet<TypeDefectTel> TypeDefectTel { get; set; }
        public virtual DbSet<TypeTelephones> TypeTelephones { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Client> Client { get; set; }
    }
}