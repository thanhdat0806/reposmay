﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KT100720_59131885.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class TaiSan
    {
        [Required(ErrorMessage ="Vui lòng nhập mã tài sản")]
        [DisplayName("Mã tài sản")]
        public string MaTS { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập tên tài sản")]
        [DisplayName("Tên tài sản")]
        public string TenTS { get; set; }
        [DisplayName("Đơn vị tính")]
        public string DVT { get; set; }
        [DisplayName("Xuất xứ")]
        public Nullable<bool> XuatXu { get; set; }
        [DisplayName("Đơn giá")]
        public int DonGia { get; set; }
        [DisplayName("Ảnh minh họa")]
        public string AnhMH { get; set; }
        [DisplayName("Mã loại tài sản")]
        public string MaLTS { get; set; }
        [DisplayName("Ghi chú")]
        public string GhiChu { get; set; }
    
        public virtual LoaiTaiSan LoaiTaiSan { get; set; }
    }
}
