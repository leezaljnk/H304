//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class PhieuDeNghi
    {
        public System.Guid ID { get; set; }
        public string Ma { get; set; }
        public Nullable<System.DateTime> NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public Nullable<System.Guid> MaKhoNhap { get; set; }
        public Nullable<System.Guid> MaKhoXuat { get; set; }
        public Nullable<short> LoaiPhieu { get; set; }
    }
}
