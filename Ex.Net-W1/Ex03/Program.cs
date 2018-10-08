using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap nam: ");
            int year = int.Parse(Console.ReadLine());
            Console.Write("Nhap thang: ");
            int month = int.Parse(Console.ReadLine());

            DrawCalendar(year, month);

            Console.ReadKey();
        }

        public static void DrawCalendar(int year, int month)
        {
            int[,] calendar = new int[5, 7] { { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 } };
            //Tính ngày tối đa trong tháng đó
            int max;
            if (month == 2)
                if (((year % 4) == 0 && (year % 100) == 0 && (year % 400) == 0) || ((year % 4) == 0 && (year % 100) != 0))
                    max = 29;
                else
                    max = 28;
            else
                if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
                max = 31;
            else
                max = 30;

            //Tìm thứ của ngày đầu tiên trong tháng
            DayOfWeek dayOfWeek = GetFistDayInMonth(year, month).DayOfWeek;
            string firstday = dayOfWeek.ToString();
            switch (firstday)
            {
                case "Monday":
                    calendar[0, 0] = 1;
                    break;
                case "Tuesday":
                    calendar[0, 1] = 1;
                    break;
                case "Wednesday":
                    calendar[0, 2] = 1;
                    break;
                case "Thursday":
                    calendar[0, 3] = 1;
                    break;
                case "Friday":
                    calendar[0, 4] = 1;
                    break;
                case "Saturday":
                    calendar[0, 5] = 1;
                    break;
                case "Sunday":
                    calendar[0, 6] = 1;
                    break;
                default:
                    break;
            }

            //Điền ngày vào mảng
            for (int x = 0; x < 5; x++)
                for (int y = 0; y < 7; y++)
                {
                    if (calendar[x, y] != 0)
                    {
                        if (y == 6 && x < 4)
                            calendar[x + 1, 0] = calendar[x, y] + 1;
                        else
                        {
                            if (x == 4 && y == 6)
                            {
                                break;
                            }
                            else calendar[x, y + 1] = calendar[x, y] + 1;
                        }
                    }

                }

            //Vẽ lịch
            Console.WriteLine();
            Console.WriteLine("Mon\t" + "Tue\t" + "Wed\t" + "Thu\t" + "Fri\t" + "Sat\t" + "Sun\t");
            for (int x = 0; x < 5; x++)
            {
                for (int y = 0; y < 7; y++)
                {
                    if (calendar[x, y] > max)
                        calendar[x, y] = 0;
                    if (calendar[x, y] == 0)
                        Console.Write(" " + "\t");
                    else
                        Console.Write(calendar[x, y] + "\t");
                }
                Console.WriteLine();
            }

        }

        public static DateTime GetFistDayInMonth(int year, int month)
        {
            DateTime aDateTime = new DateTime(year, month, 1);

            return aDateTime;
        }
    }
}
