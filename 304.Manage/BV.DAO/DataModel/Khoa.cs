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
    
    public partial class Khoa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Khoa()
        {
            this.Kho = new HashSet<Kho>();
        }
    
        public System.Guid ID { get; set; }
        public string Ma { get; set; }
        public string Ten { get; set; }
        public Nullable<int> NhomKhoaId { get; set; }
        public string MoTa { get; set; }
        public string MaBYT { get; set; }
        public string TenBYT { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kho> Kho { get; set; }
        public virtual NhomKhoa NhomKhoa { get; set; }
    }
}
