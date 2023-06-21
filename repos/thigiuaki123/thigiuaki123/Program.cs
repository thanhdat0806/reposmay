using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Thigiuaki
{
	class DongCo
	{
		int _namSx = 0;
		public DongCo()
		{
		}
		public DongCo(int namSx)
		{
			_namSx = namSx;
		}
		public DongCo(DongCo dc)
		{
			_namSx = dc._namSx;
		}
		public void Nhap()
		{
			Console.WriteLine("Nhap nam xan xuat:");
			_namSx = int.Parse(Console.ReadLine());
		}
		public void Xuat()
		{
			Console.WriteLine("Nam SX:{0}", _namSx);
		}
	}
	class XeHoi : DongCo
	{
		string _bienSo;
		public XeHoi() : base()
		{
		}
		public XeHoi(string bienSo, int namSx) : base(namSx)
		{
			_bienSo = bienSo;
		}
		public XeHoi(XeHoi xh) : base((DongCo) xh)
		{
			_bienSo = xh._bienSo;
		}

		public new void Nhap()
		{
			base.Nhap();
			Console.WriteLine("nhap bien so:");
			_bienSo = Console.ReadLine();
			Console.WriteLine("------------------------------------");
		}
		public new void Xuat()
		{
			base.Xuat();
			Console.Write("Bien so:{0}", _bienSo);
		}
		/*static public void Min(XeHoi[] xh, int n)
		{
			int min = 0;
			int vitri = 0;
			for (int i = 0; i < n; i++)
			{
				if (min > xh._namSX)
				{
					min = xh.NamSx;
					vitri = i;
				}
			}
			Console.WriteLine("xe co nam sx cu nhat la:");
			xh[vitri].Xuat();
		}*/
		static public void tim(XeHoi xh, int n)
		{
			string a = { 79 };
			Console.WriteLine("nhap bien so muon tim :");
			a = Console.ReadLine();
			for (int i = 0; i < n; i++)
			{
				if (a[0] == p[i].BienSo[0] && a[1] == p[i].BienSo[1])
				{
					p[i].Xuat();
				}
				else
				{
					Console.WriteLine("kh co xe nay");
				}
			}
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			int n;
			XeHoi xh1 = new XeHoi();

			Console.WriteLine("nhap so xe con:");
			n = int.Parse(Console.ReadLine());
			for (int i = 0; i < n; i++)
			{
				Console.WriteLine("nhap thong tin xe:");
				xh1.Nhap();
			}
			for (int i = 0; i < n; i++)
            {
				Console.WriteLine("Thong tin xe:");
				xh1.Xuat();
			}			
			Console.WriteLine("------------------------------------");
		}
	}
}