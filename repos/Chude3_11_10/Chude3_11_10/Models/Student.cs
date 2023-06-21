using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace Chude3_11_10.Models
{
    public class Student
    {
        [DisplayName("Mã sinh viên")]
        public String Id { get; set; }
        [DisplayName("Mật khẩu")]
        public String Password { get; set; }
        [DisplayName("Họ và tên")]
        public String Fullname { get; set; }
        [DisplayName("Giới tính")]
        public bool Gender { get; set; }
        [DisplayName("Ngày sinh")]
        public DateTime Birthday { get; set; }
        [DisplayName("Ghi chú")]
        public String Notes { get; set; }
    }
}