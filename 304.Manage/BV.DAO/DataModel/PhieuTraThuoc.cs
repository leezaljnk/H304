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
    
    public partial class PhieuTraThuoc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PhieuTraThuoc()
        {
            this.PhieuTraThuocChiTiet = new HashSet<PhieuTraThuocChiTiet>();
            this.XuatTra = new HashSet<XuatTra>();
        }
    
        public System.Guid ID { get; set; }
        public System.Guid KhoId { get; set; }
        public string MaPhieuTra { get; set; }
        public System.DateTime NgayLap { get; set; }
        public Nullable<System.Guid> NguoiLap { get; set; }
        public string GhiChu { get; set; }
        public short TinhTrang { get; set; }
        public string LyDoLuuThuHoi { get; set; }
    
        public virtual Kho Kho { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuTraThuocChiTiet> PhieuTraThuocChiTiet { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<XuatTra> XuatTra { get; set; }
    }
}