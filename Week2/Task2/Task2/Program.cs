using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream a = new FileStream(@"D:\Task2.txt", FileMode.Open, FileAccess.Read);
            StreamReader b = new StreamReader(a);
            string l = b.ReadLine();
            string[] s = l.Split();
            int n = s.Length;
            int[] mass = new int[n];
            for (int i = 0; i < n; i++)
            {
                mass[i] = int.Parse(s[i]);
            }
            string path = @"D:\Task2out.txt";
            File.Create(path).Close();
            FileStream a1 = new FileStream(path, FileMode.Append, FileAccess.Write);
            StreamWriter b1 = new StreamWriter(a1);
            for (int i = 0; i < n; i++)
            {
                int c = 0;
                if (mass[i] == 1)
                {
                    mass[i] = 0;
                }
                else
                {
                    for (int k = 2; k < mass[i]; k++)
                    {
                        if (mass[i] % k == 0)
                        {
                            c++;
                        }
                    }
                    if (c != 0)
                    {
                        mass[i] = 0;
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                if (mass[i] != 0)
                {
                    b1.Write(mass[i] + " ");
                }
            }
            b1.Close();
            a1.Close();
            b.Close();
            a.Close();
        }
    }
}
