﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Thi_LeDucBinh_59130126.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class SACH
    {
        [DisplayName("Mã Sách")]
        public string MaSach { get; set; }
        [DisplayName("Tên Sách")]
        public string TenSach { get; set; }
        [DisplayName("Ảnh Đại Diện")]
        public string AnhDaiDien { get; set; }
        [DisplayName("Mô Tả")]
        public string MoTa { get; set; }
        [DisplayName("Ngôn Ngữ")]
        public bool NgonNgu { get; set; }
        [DisplayName("Đơn Giá")]
        public int DonGia { get; set; }
        [DisplayName("Tác Giả")]
        public string TacGia { get; set; }
        [DisplayName("Mã Loại Sách")]
        public string MaLS { get; set; }
    
        public virtual LOAISACH LOAISACH { get; set; }
    }
}
