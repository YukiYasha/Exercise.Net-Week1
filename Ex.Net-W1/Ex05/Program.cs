using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05
{
    class Program
    {
        static bool IsSNT(long x)
        {
            long i;
            if (x < 2) return false;
            for (i = 2; i <= Math.Sqrt(x); i++)
                if (x % i == 0)
                    return false;
            return true;
        }

        static void Main(string[] args)
        {
            Console.Write("Nhap so nguyen duong: ");
            long n = long.Parse(Console.ReadLine());
            long Sum = 0;

            for (long i = 0; i < n; i++)
            {
                if(IsSNT(i) == true)
                {
                    Sum += i;
                }
            }

            Console.Write("Tong cac so nguyen to nho hon {0}: {1}", n, Sum);
            Console.ReadKey();
        }
    }
}
