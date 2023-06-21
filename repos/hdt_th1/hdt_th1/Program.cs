using System;

namespace Calculator
{
    class Program
    {
        static int Main()
        {
            int h;
            long n;
            int i = 1;

            Console.Write("Nhap so vi trung ban dau:");
            n = long.Parse(Console.ReadLine());
            Console.Write("Nhap so gio:");
            h = int.Parse(Console.ReadLine());
            while(i<=h)
            {
                    n = n*2;
                    i++;
            }
            Console.Write("So luong  vi trung sau {0} gio la:{1}",h,n);
            return i;
        }
    }
}