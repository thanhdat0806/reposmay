//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KT0720LeDucBinh_59130126.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;

    public partial class SANPHAM
    {
        [DisplayName("Ma San Pham")]
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public string DVT { get; set; }
        public int DonGia { get; set; }
        public Nullable<bool> XuatXu { get; set; }
        public string NhaCungCap { get; set; }
        public string GhiChu { get; set; }
        public string MaLSP { get; set; }
    
        public virtual LOAISP LOAISP { get; set; }
    }
}
