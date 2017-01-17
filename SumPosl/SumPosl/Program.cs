using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace SumPosl
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s1;
            string m;
            int g = 0;
            int h = 0;
            bool f1;
            bool f2;
            using (StreamReader r = new StreamReader("input.txt"))
            {
                do
                {
                    m = r.ReadLine();
                    s1[g] = m;
                    g++;
                    f1 = s1[s1.Length - 1] == "0";
                    f2 = s1[s1.Length - 2] == "0";
                } while (f2 && f1 == true);
                int[] a = new int[g];
                for(int i = 0; i != s1.Length - 1; i++)
                {
                    a[i] = Convert.ToInt32(s1[i]);
                }
                for(int i = 0; i != a.Length - 1; i++)
                {
                    h += a[i];
                }
            }
            using(StreamWriter w = new StreamWriter("output.txt"))
            {
                w.WriteLine(h);
            }
        }
    }
}
