using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream a = new FileStream(@"D:\task1.txt", FileMode.Open, FileAccess.Read);
            StreamReader b = new StreamReader(a);
            string s = b.ReadLine();
            Console.WriteLine(s);
            int cnt = 0;
            for(int i = 0; i < s.Length/2; i++)
            {
                if (s[i] == s[s.Length - 1 -i])
                {
                    cnt++;
                }
            }
            if (cnt == s.Length / 2)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            b.Close();
            a.Close();
        }
    }
}
