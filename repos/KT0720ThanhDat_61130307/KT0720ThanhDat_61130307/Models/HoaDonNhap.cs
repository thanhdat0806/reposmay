//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KT0720ThanhDat_61130307.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class HoaDonNhap
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HoaDonNhap()
        {
            this.CTHDNs = new HashSet<CTHDN>();
        }
    
        public string SoHD { get; set; }
        public System.DateTime NgayNhap { get; set; }
        public string MaNV { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTHDN> CTHDNs { get; set; }
        public virtual NhanVien NhanVien { get; set; }
    }
}
