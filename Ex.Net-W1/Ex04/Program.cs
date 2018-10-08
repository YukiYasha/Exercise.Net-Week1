using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ex04
{
    class Program
    {
        static void GhiFile(int []arr, string filename)        
        {            
            using (FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.Write))
            {
                StreamWriter sw = new StreamWriter(fs);
                for (int i = 0; i < arr.Length; i++)
                {
                    sw.WriteLine(arr[i]);
                }

                sw.Close();
            }


            //===================================================                     
            /*FileInfo fi = new FileInfo(filename);
            StreamWriter sw = fi.CreateText();
            for (int i = 0; i < arr.Length; i++)
            {
                sw.WriteLine(arr[i]);
            }

            sw.Close();*/
        }

        static void DocFile(ref int []arr, string filename)
        {
            using (FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read))
            {
                StreamReader sr = new StreamReader(filename);
                string line = null;
                int i = 0;

                while ((line = sr.ReadLine()) != null)
                {
                    arr[i++] = int.Parse(line);
                }

                sr.Close();                
            }

            //===================================================           
            /*StreamReader sr = File.OpenText(filename);
            string line = null;
            int i = 0;

            while ((line = sr.ReadLine()) != null)
            {
                arr[i++] = int.Parse(line);
            }

            sr.Close();*/
        }

        static void XuatMang(int []arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0}  ", arr[i]);
            }
            Console.WriteLine();
        }

        static void swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        static void QuickSort(ref int []arr, int left, int right)
        {
            int i, j, mid;
            if (left >= right)
                return;
            mid = arr[(left + right) / 2];
            i = left; j = right;

            while (i < j)
            {
                while (arr[i] < mid) i++;
                while (arr[j] > mid) j--;
                if (i <= j)
                {

                    swap(ref arr[i], ref arr[j]);
                    i++; j--;
                }
            }

            QuickSort(ref arr, left, j);
            QuickSort(ref arr, i, right);
        }

        static void TachSoChanLe(int []arr)
        {
            FileStream fs1 = new FileStream("fileChan.txt", FileMode.Create, FileAccess.Write);
            FileStream fs2 = new FileStream("fileLe.txt", FileMode.Create, FileAccess.Write);
            StreamWriter sw1 = new StreamWriter(fs1);
            StreamWriter sw2 = new StreamWriter(fs2);

            Console.WriteLine("\nDa ghi file day so chan: ");
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] % 2 == 0)
                {
                    Console.Write("{0}  ", arr[i]);
                    sw1.WriteLine(arr[i]);
                }

            Console.WriteLine("\n\nDa ghi file day so le: ");
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] % 2 != 0)
                {
                    Console.Write("{0}  ", arr[i]);
                    sw2.WriteLine(arr[i]);
                }

            sw1.Close();
            sw2.Close();
        }

        static void Main(string[] args)
        {
            Console.Write("Nhap so nguyen duong (n > 2): ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Random rd = new Random();

            for (int i = 0; i < n; i++)
            {
                arr[i] = rd.Next(0, 1000);
            }

            //File trong thư mục bin\Debug của project
            GhiFile(arr, "MangNgauNhien.txt");
            Console.WriteLine("\nDa ghi file mang ngau nhien: ");
            XuatMang(arr);

            DocFile(ref arr, "MangNgauNhien.txt");
            QuickSort(ref arr, 0, arr.Length - 1);
            Console.WriteLine("\nDa ghi file mang sap xep tang dan: ");
            GhiFile(arr, "SapXepTang.txt");
            XuatMang(arr);

            TachSoChanLe(arr);
            Console.ReadKey();
        }
    }
}
