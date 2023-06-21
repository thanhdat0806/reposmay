/*
Bài kiểm tra giữa kỳ.
Họ và tên: Nguyễn Thành Đạt
MSSV: 61130137
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLXe
{
    class DongCo
    {
        private int _namSX;
        public int NamSx
        {
            get { return _namSX; }
            set { _namSX = value; }
        }
        public DongCo()
        {
            NamSx = 0;
        }
        public DongCo(int n)
        {
            NamSx = n;
        }
        public void Nhap()
        {
            Console.WriteLine("Nhap nam san xuat:");
            NamSx = int.Parse(Console.ReadLine());
        }
        public void Xuat()
        {
            Console.WriteLine("Nam san xuat:{0}", NamSx);
        }
    }
    class XeHoi
    {
        private string _bienSo;
        public string BienSo
        {
            get { return _bienSo; }
            set { _bienSo = value; }
        }
        public XeHoi()
        {
            BienSo = "";
        }
        public XeHoi(string b)
        {
            BienSo = b;
        }
        public void NhapBS()
        {
            Console.WriteLine("Nhap bien so xe:");
            BienSo = Console.ReadLine();
            Console.WriteLine("------------------------");
        }
        public void XuatBS()
        {

            Console.WriteLine("Bien so:{0}", BienSo);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            XeHoi[] p = new XeHoi[50];
            do
            {
                Console.WriteLine("Nhap so xe hoi:");
                n = int.Parse(Console.ReadLine());
                if (n < 3 || n > 100)
                {
                    Console.WriteLine("So xe khong hop le(3<=n<=100). Xin nhap lai.");
                }
            } while (n < 3 || n > 100);
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap thon tin xe:");
                p[i] = new XeHoi();
                p[i].Nhap();
                p[i].NhapBS();
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Thong tin xe {0}:", i);
                p[i].Xuat();
                p[i].XuatBS();
            }
        }
    }
}
