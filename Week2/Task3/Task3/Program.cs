using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void PrintInfo(FileSystemInfo fsi, int k)
        {
            string s = new string(' ', k);
            Console.WriteLine(s + fsi.Name);
            if (fsi.GetType() == typeof(DirectoryInfo))
            {
                var t = fsi as DirectoryInfo;
                foreach(var x in y.GetFileSystemInfos())
                {
                    PrintInfo(x, k + 3);
                }
            }
        }
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(@"D:\Task2");
            PrintInfo(dir, 0);
        } 
    }
}
