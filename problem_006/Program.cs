using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_006
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n = 0;
            double m = 0;
            for (double i = 1; i <= 100; i++)
            {
                double a = Math.Pow(i, 2);
                n = n + a;

                m = m + i;

            }
            Console.WriteLine(n);
            double b = Math.Pow(m, 2);
            Console.WriteLine(b);
            double rozdil = b - n;
            Console.WriteLine(rozdil);
        }
    }
}
