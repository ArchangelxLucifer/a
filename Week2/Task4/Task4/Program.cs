using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream a = new FileStream(@"D:\TASKkk4\1.txt", FileMode.Create);
            File.Copy(@"D:\TASKkk4\1.txt", @"D:\Tasssk4\1.txt", true);
            a.Close();
            File.Delete(@"D:\TASKkk4\1.txt");
        }
    }
}
