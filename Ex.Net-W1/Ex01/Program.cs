using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap nam: ");
            int Nam = int.Parse(Console.ReadLine());
            Console.Write("Nhap thang: ");
            int Thang = int.Parse(Console.ReadLine());

            if (Thang <= 0 || Thang > 12)
            {
                Console.WriteLine("\nNhap thang sai!!! Exit in 2s!");
                Thread.Sleep(2000);
                return;
            }
            if (Thang == 2)
                if (((Nam % 4) == 0 && (Nam % 100) == 0 && (Nam % 400) == 0) || ((Nam % 4) == 0 && (Nam % 100) != 0))
                    Console.WriteLine("\nThang {0} nam {1} co 29 ngay", Thang, Nam);
                else
                    Console.WriteLine("\nThang {0} nam {1} co 28 ngay", Thang, Nam);
            else
                if (Thang == 1 || Thang == 3 || Thang == 5 || Thang == 7 || Thang == 8 || Thang == 10 || Thang == 12)
                Console.WriteLine("\nThang {0} nam {1} co 31 ngay", Thang, Nam);
            else
                Console.WriteLine("\nThang {0} nam {1} co 30 ngay", Thang, Nam);
            Console.WriteLine("\nNhan [Enter] de thoat...");
            Console.ReadLine();
        }
    }
}
