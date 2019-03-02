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
    
    public partial class PhieuXuatKho
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PhieuXuatKho()
        {
            this.PhieuXuatChiTiet = new HashSet<PhieuXuatChiTiet>();
        }
    
        public System.Guid ID { get; set; }
        public string Ma { get; set; }
        public Nullable<System.DateTime> NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public Nullable<System.Guid> MaKhoNhap { get; set; }
        public Nullable<System.Guid> MaKhoXuat { get; set; }
        public Nullable<System.DateTime> NgayXuatKho { get; set; }
        public string NguoiNhan { get; set; }
        public Nullable<double> TongTien { get; set; }
        public Nullable<double> ThanhTien { get; set; }
        public Nullable<int> MaPhanLoaiHoaDon { get; set; }
        public string TenPhanLoaiHoaDon { get; set; }
        public Nullable<System.Guid> PhieuDeNghiId { get; set; }
        public Nullable<System.Guid> KhoId { get; set; }
    
        public virtual PhanLoaiHoaDon PhanLoaiHoaDon { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuXuatChiTiet> PhieuXuatChiTiet { get; set; }
    }
}
