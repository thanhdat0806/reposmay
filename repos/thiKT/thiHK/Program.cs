using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiKT1
{
    class NhanVien
    {
        private string ngaysinh;
        private string HoTenNV;
        public NhanVien()
        {
            ngaysinh = "";
            HoTenNV = "";
        }
        public NhanVien(string m, string h)
        {
            m = ngaysinh;
            h = HoTenNV;
        }
        public void nhap()
        {

            Console.Write("Nhap ho ten nhan vien: ");
            HoTenNV = Console.ReadLine();
            Console.Write("Nhap ma nhan vien: ");
            ngaysinh = Console.ReadLine();
        }
        public void xuat()
        {
           
            Console.WriteLine("Ho ten nhan vhien: {0}", HoTenNV);
            Console.WriteLine("Ngay sinh nhan vien: {0}", ngaysinh);
        }
    }

    class NhanVienVanPhong : NhanVien
    {
        private float HeSoLuong;
        public NhanVienVanPhong() : base()
        {
            HeSoLuong = 0;
        }
        public NhanVienVanPhong(string h, string d, float hs)
        {
            hs = HeSoLuong;
        }
        public new void nhap()
        {
            base.nhap();
            Console.Write("Nhap he so luong: ");
            HeSoLuong = Convert.ToInt32(Console.ReadLine());
        }
        public new void xuat()
        {
            base.xuat();
            Console.WriteLine("Luong: {0}", (float)HeSoLuong * 1.5);
        }
    }
    class NhanVienSanXuat : NhanVien
    {
        private int SoNgayCong;
        public NhanVienSanXuat() : base()
        {
            SoNgayCong = 0;
        }
        public NhanVienSanXuat(string h, string d, int sn)
        {
            sn = SoNgayCong;
        }
        public new void nhap()
        {
            base.nhap();
            Console.Write("Nhap so ngay cong: ");
            SoNgayCong = Convert.ToInt32(Console.ReadLine());
        }
        public new void xuat()
        {
            base.xuat();
            Console.WriteLine("Luong: {0}", (float)SoNgayCong * 1.5 / 5);
        }
    }

    class DSNhanVien
    {
        private int n;
        private int tam;
        public void NhapDS()
        {
            do
            {
                Console.Write("Nhap so nhan vien: ");
                n = Convert.ToInt32(Console.ReadLine());
            } while (n <= 0 || n >= 100);
            for (int i = 0; i < n; i++)
            {
                do
                {
                    Console.WriteLine("Chon phuong thuc nhap: 1 = nhan vien san xuat; 2 = nhan vien van phong");
                    tam = Convert.ToInt32(Console.ReadLine());
                } while (tam < 1 || tam > 2);
                if (tam == 1)
                {
                    Console.WriteLine("Nhap thong tin nhan vien: ");
                    NhanVien nvsx = new NhanVienSanXuat();
                    nvsx.nhap();
                }
                else
                {
                    Console.WriteLine("Nhap thong tin nhan vien: ");
                    NhanVien nvvp = new NhanVienVanPhong();
                    nvvp.nhap();
                }
            }
        }
        public void XuatDS()
        {

            for (int i = 0; i < n; i++)
            {
                NhanVien nv = new NhanVien();
                nv.xuat();
                Console.WriteLine("__________________________");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            DSNhanVien nv = new DSNhanVien();
            nv.NhapDS();
            nv.XuatDS();
            Console.ReadKey();

            //tim luong lon nhat 
            int d = 0;
            while (d < n)
            {
                int vtmax = 0;
                for (int i = 1; i < n; i++)
                {
                    if (p[vtmax].inluong() <= p[i].inluong())
                    {
                        vtmax = i;
                    }
                }
                p[vtmax].Xuat();
                //xoa so lon nhat trong mang
                for (int i = vtmax; i < n - 1; i++)
                {
                    p[i] = p[i + 1];
                }
                d++;
            }
            //Sap xep nhan vien giam dan theo luong
            NhanVien temp = new NhanVien();
            for (int i = 0; i < _n - 1; i++)
            {
                for (int j = i + 1; j < _n; j++)
                {
                    if (NhanVien[i].Luong() < NhanVien[j].Luong())
                    {
                        temp = NhanVien[i];
                       NhanVien[i] = NhanVien[j];
                        NhanVien[j] = temp;
                    }
                }
            }
        }
}