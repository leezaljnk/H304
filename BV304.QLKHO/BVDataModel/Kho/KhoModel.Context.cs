﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BV.DataModel.Kho
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class KhoEntities : DbContext
    {
        public KhoEntities()
            : base("name=KhoEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ChiTietPhieu> ChiTietPhieu { get; set; }
        public virtual DbSet<PhieuDeNghi> PhieuDeNghi { get; set; }
        public virtual DbSet<PhieuNhapKho> PhieuNhapKho { get; set; }
        public virtual DbSet<PhieuXuatKho> PhieuXuatKho { get; set; }
        public virtual DbSet<Thuoc_VatTuYteTonKho> Thuoc_VatTuYteTonKho { get; set; }
    }
}
