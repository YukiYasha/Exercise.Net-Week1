using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap ngay: ");
            int Day = int.Parse(Console.ReadLine());

            Console.Write("Nhap thang: ");
            int Month = int.Parse(Console.ReadLine());

            Console.Write("Nhap nam: ");
            int Year = int.Parse(Console.ReadLine());

            DateTime date = new DateTime(Year, Month, Day);

            Console.WriteLine(date.DayOfWeek);
            
            Console.ReadKey();
        }
    }
}
