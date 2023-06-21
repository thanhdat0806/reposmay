using System;

namespace hdtth2
{
    public class PhanSo
    {
        private int _tuSo = 0, _mauSo = 1; // Đây là dữ liệu riêng (private), không cho phép truy xuất từ bên ngoài lớp

        public int TuSo
        {        // Thuộc tính (property)
            get { return _tuSo; }  // Đọc giá trị của trường _tuSo từ ngoài lớp
                                   // get => _tuSo;
            set { _tuSo = value; } // Thay đổi giá trị của trường _tuSo từ ngoài lớp
                                   // set => _tuSo = value;
        }

        public int MauSo
        {
            get => _mauSo; // Đọc giá trị của trường _mauSo
                           // Không có phương thức set -> không thay đổi được từ bên ngoài lớp
        }

        // Hàm thiết lập (constructor)
        public PhanSo(int tuSo = 0, int mauSo = 1)
        {
            // Mẫu số phải khác 0
            if (mauSo == 0)
                throw new ArgumentException("Mau so phai khac 0.", nameof(mauSo));
            this._tuSo = tuSo;
            this._mauSo = mauSo;
        }

        // Hàm thiết lập sao chép
        public PhanSo(PhanSo p)
        {
            _tuSo = p._tuSo;
            _mauSo = p._mauSo;
        }
        public void Nhap()
        {
            Console.Write("Tu so = ");
            _tuSo = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.Write("Mau so = ");
                _mauSo = Convert.ToInt32(Console.ReadLine());
                if (_mauSo == 0) Console.WriteLine("Mau so phai != 0");
            } while (_mauSo == 0);
        }

        public void Xuat()
        {
            Console.WriteLine("{0}/{1}", _tuSo, _mauSo);
        }

        // Tối giản phân số
        public void ToiGian()
        {
            int ucln = 1;
            for (int i = Math.Min(Math.Abs(_tuSo), Math.Abs(_mauSo)); i > 1; i--)
                if (_mauSo % i == 0 && _tuSo % i == 0)
                {
                    ucln = i;
                    break;
                }
            _tuSo /= ucln;
            _mauSo /= ucln;
        }

        // Hàm trả về giá trị của phân số (lấy ts/ms)
        public double GiaTri()
        {
            return Convert.ToDouble(_tuSo) / _mauSo;
        }

        // Hàm cộng phân số với một phân số khác
        // = this._tuSo/this._mauSo + p._tuSo/p._mauSo
        public void Cong(PhanSo p)
        {
            _tuSo = _tuSo * p._mauSo + _mauSo * p._tuSo;
            _mauSo = _mauSo * p._mauSo;
        }


    }
    class Program
    {
        static void Main(string[] args)
        {

            PhanSo p1 = new PhanSo(); // Tạo đối tượng phân số
            p1.Nhap();   // Gọi phương thức Nhap()
            p1.Xuat();   // Gọi phương thức Xuat()
            Console.WriteLine("Tu so = {0}", p1.TuSo);   // Thực hiện được vì thuộc tính TuSo cho phép đọc {get;} giá trị _tuSo
            Console.WriteLine("Mau so = {0}", p1.MauSo); // Thực hiện được vì thuộc tính MauSo cho phép đọc {get;} giá trị _mauSo       
                                                         //p1.TuSo = 10;                                // Thực hiện được vì thuộc tính TuSo cho phép thay đổi {set;} giá trị _tuSo
            Console.WriteLine("Tu so = {0}", p1.TuSo);
            // p.MauSo = 10;                            // Không thực hiện được vì thuộc tính MauSo không cho thay đổi {set;} giá trị _mauSo
            // Tối giản phân số
            p1.ToiGian();
            // In ra phân số tối giản:
            Console.WriteLine("Phan so toi gian:");
            p1.Xuat();
            // Tạo phân số sử dụng hàm thiết lập
            PhanSo p2 = new PhanSo(21, 49);
            p2.Xuat();
            p2.ToiGian();
            p2.Xuat();
            // p1 = p1 + p2
            p1.Cong(p2);
            // In ra p1 sau khi cộng thêm p2
            Console.WriteLine("Tong 2 phan so:");
            p1.ToiGian();
            p1.Xuat();
        }
    }
}
