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
    
    public partial class XuatTraChiTiet
    {
        public System.Guid ID { get; set; }
        public System.Guid ThuocId { get; set; }
        public System.Guid PhieuNhapID { get; set; }
        public string SoLo { get; set; }
        public int SoLuong { get; set; }
        public Nullable<decimal> Gia { get; set; }
        public string HoaDonID { get; set; }
        public System.Guid XuaTraId { get; set; }
        public Nullable<System.Guid> LoHangID { get; set; }
    
        public virtual HangHoa HangHoa { get; set; }
        public virtual LoHangHoa LoHangHoa { get; set; }
        public virtual XuatTra XuatTra { get; set; }
    }
}
