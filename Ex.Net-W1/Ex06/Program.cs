using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ex06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap duong dan tap tin: ");
            string FilePath = Console.ReadLine();

            if (File.Exists(FilePath))
            {
                Console.WriteLine("Xoa tap tin???\n1. Yes\n2. No");

                if (int.Parse(Console.ReadLine()) == 1)
                {
                    File.Delete(FilePath);
                    if (!File.Exists(FilePath))
                        Console.WriteLine("Da xoa tap tin!!!");
                    Console.ReadKey();
                    return;
                }
                else
                    return;
            }
            else
            {
                Console.WriteLine("Tap tin khong ton tai!!!");
                Console.ReadKey();
                return;
            }
        }
    }
}
