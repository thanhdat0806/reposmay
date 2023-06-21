using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace QLThietBi

{

    class Device

    {

        private string maso;

        private string hangsx;

        private int namsx;

        private int gia;

        public string MaSo

        {

            set { maso = value; }

            get { return maso; }

        }

        public string HangSx

        {

            set { hangsx = value; }

            get { return hangsx; }

        }

        public int NamSX

        {

            set { namsx = value; }

            get { return namsx; }

        }

        public int Gia

        {

            set { gia = value; }

            get { return gia; }

        }

        public Device()

        {



        }

        public Device(string a, string b, int c, int d)

        {

            MaSo = a;

            HangSx = b;

            NamSX = c;

            Gia = d;

        }

        public virtual void Nhap()

        {

            Console.WriteLine("Nhap ma so:");

            MaSo = Console.ReadLine();

            Console.WriteLine("Nhap hang sx:");

            HangSx = Console.ReadLine();

            Console.WriteLine("Nhap nam sx:");

            NamSX = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhap gia:");

            Gia = int.Parse(Console.ReadLine());

        }

        public virtual void Xuat()

        {

            Console.WriteLine("Ma so:{0}", MaSo);

            Console.WriteLine("Hang sx:{0}", HangSx);

            Console.WriteLine("Nam sx:{0}", NamSX);

            Console.WriteLine("Gia:{0}", Gia);

        }

    }

    class TV : Device

    {

        private int kichthuoc;

        private int phangiai;

        public int KichThuoc

        {

            set { kichthuoc = value; }

            get { return kichthuoc; }

        }

        public int PhanGiai

        {

            set { phangiai = value; }

            get { return phangiai; }

        }

        public TV() : base()

        {



        }

        public TV(string a, string b, int c, int d, int e, int f) : base(a, b, c, d)

        {

            KichThuoc = e;

            PhanGiai = f;

        }

        public override void Nhap()

        {

            base.Nhap();

            Console.WriteLine("Nhap kich thuoc:");

            KichThuoc = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhap do phan giai");

            PhanGiai = int.Parse(Console.ReadLine());

        }

        public override void Xuat()

        {

            base.Xuat();

            Console.WriteLine("Kich thuoc :{0}", KichThuoc);

            Console.WriteLine("Do phan giai:{0}", PhanGiai);

        }

    }

    class MayGiat : Device

    {

        private int khoiluong;

        private string congnghe;

        public int KhoiLuong

        {

            set { khoiluong = value; }

            get { return khoiluong; }

        }

        public string CongNghe

        {

            set { congnghe = value; }

            get { return congnghe; }

        }

        public MayGiat() : base()

        {



        }

        public MayGiat(string a, string b, int c, int d, int e, string f) : base(a, b, c, d)

        {

            KhoiLuong = 0;

            CongNghe = "";

        }

        public override void Nhap()

        {

            base.Nhap();

            Console.WriteLine("Nhap khoi luong:");

            KhoiLuong = int.Parse(Console.ReadLine());

            Console.WriteLine("Co cong nghe hay khong:");

            CongNghe = Console.ReadLine();

        }

        public override void Xuat()

        {

            base.Xuat();

            Console.WriteLine("Khoi luong :{0}", KhoiLuong);

            Console.WriteLine("Cong nghe:{0}", CongNghe);

        }

    }

    class Program

    {

        static void Main(string[] args)

        {

            int n;

            int check;

            int kt = 0;

            int demTV = 0;

            int demMG = 0;

            Console.Write("Nhap so thiet bi(0<n<100):");

            n = int.Parse(Console.ReadLine());

            Device[] p = new Device[n];

            int[] vt = new int[100];

            // in danh sach thiet bi

            for (int i = 0; i < n; i++)

            {

                Console.Write("Tivi(1)....Maygiat(2):");

                check = int.Parse(Console.ReadLine());

                if (check == 1)

                {

                    p[i] = new TV();

                    p[i].Nhap();

                    demTV++;

                }

                if (check == 2)

                {

                    p[i] = new MayGiat();

                    p[i].Nhap();

                    demMG++;

                    vt[kt] = i;

                    kt++;

                }

            }

            for (int i = 0; i < n; i++)

            {

                p[i].Xuat();

            }

            //thong ke so luong moi loai thiet bi

            Console.WriteLine("So luong Tivi la:{0}", demTV);

            Console.WriteLine("So luong may giat la:{0}", demMG);

            // sap xep danh sach

            int tam;

            for (int i = 0; i < n - 1; i++)

            {

                for (int j = i + 1; j < n; j++)

                {

                    if (p[i].NamSX > p[j].NamSX)

                    {

                        tam = p[i].NamSX;

                        p[i].NamSX = p[j].NamSX;

                        p[j].NamSX = tam;

                    }

                }

            }

            for (int i = 0; i < n; i++)

            {

                p[i].Xuat();

            }

            // tim may giat co khoi luong lon nhat

            MayGiat[] a = new MayGiat[n];

            for (int i = 0; i < n; i++)

            {

                a[i] = p[(vt[i])];

            }

            int max = a[1].KhoiLuong();

            for (int i = 0; i < n - 1; i++)

            {

                if (a[i].KhoiLuong > a[i + 1].KhoiLuong)

                {



                }

            }

        }

    }

}