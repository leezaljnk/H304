//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BV.DataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class dm_dichvu_dong
    {
        public int ID { get; set; }
        public string MaDichVu { get; set; }
        public string MaKhoa { get; set; }
        public string Nhom { get; set; }
        public string TenDichVu { get; set; }
        public Nullable<double> GiaThuPhi { get; set; }
        public Nullable<double> GiaBaoHiem { get; set; }
        public Nullable<double> TiLeThanhToan { get; set; }
        public string NhomBHYT_Cu { get; set; }
        public Nullable<int> NhomBHYT { get; set; }
        public string MaBYT { get; set; }
        public string TenBYT { get; set; }
        public Nullable<System.DateTime> NgayHieuLuc { get; set; }
        public Nullable<System.DateTime> NgayHetHieuLuc { get; set; }
        public Nullable<int> CreateByID { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<int> ModifyID { get; set; }
        public Nullable<System.DateTime> ModifyDate { get; set; }
        public Nullable<bool> Active { get; set; }
    }
}
