//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KT2_59136106.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class QUANAO
    {
        public string MAQA { get; set; }
        public string TenQA { get; set; }
        public string MOTA { get; set; }
        public int DonGia { get; set; }
        public Nullable<bool> XuatXu { get; set; }
        public string Anh { get; set; }
        public string MaLQA { get; set; }
    
        public virtual LOAIQUANAO LOAIQUANAO { get; set; }
    }
}