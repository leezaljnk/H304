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
    
    public partial class PhieuNhapKho
    {
        public System.Guid ID { get; set; }
        public string Ma { get; set; }
        public Nullable<System.DateTime> NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public System.Guid MaNhaCungCap { get; set; }
        public string NhaCungCap { get; set; }
        public string NguoiCungCap { get; set; }
        public string SoHoaDon { get; set; }
        public Nullable<System.DateTime> NgayHoaDon { get; set; }
        public Nullable<double> VAT { get; set; }
        public Nullable<double> TongTien { get; set; }
        public Nullable<double> ThanhTien { get; set; }
        public string MaPhanLoaiHoaDon { get; set; }
        public string TenPhanLoaiHoaDon { get; set; }
    }
}
