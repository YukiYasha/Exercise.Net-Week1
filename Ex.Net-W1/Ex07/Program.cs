using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap duong dan thu muc: ");
            string FilePath = Console.ReadLine();
            DirectoryInfo dirInfo = new DirectoryInfo(FilePath);

            // Một mảng các thư mục con.
            DirectoryInfo[] childDirs = dirInfo.GetDirectories();

            // Mảng các file nằm trong thư mục.
            FileInfo[] childFiles = dirInfo.GetFiles();

            foreach (DirectoryInfo childDir in childDirs)
            {
                Console.WriteLine(childDir.CreationTime + "\t\t\t" + childDir.Name + "\t");
            }

            foreach (FileInfo childFile in childFiles)
            {
                Console.WriteLine(childFile.CreationTime + "\t" + childFile.Length + "\t\t" + childFile.Name + "\t");
            }

            Console.ReadKey();

        }
    }
}
