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
    
    public partial class KhoaPhong
    {
        public int ID { get; set; }
        public string Ten { get; set; }
        public string Nhom { get; set; }
        public string MaBYT { get; set; }
        public string TenBYT { get; set; }
        public Nullable<int> CreateByID { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<int> ModifyByID { get; set; }
        public Nullable<System.DateTime> ModifyDate { get; set; }
        public Nullable<bool> Active { get; set; }
    }
}
