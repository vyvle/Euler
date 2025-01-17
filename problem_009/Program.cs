using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_009
{
    internal class Program
    {
        bool Pyth(int a, int b, int c)
        {
            if (Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2))
                return true;
            else
                return false;
        }

        static void Main(string[] args)
        {

            int a = 0, b = 0, c = 0;
            int s = 1000;
            bool pyth = true;

            for (a = 3; a < s / 3; a++)
            {
                for (b = a + 1; b < s / 2; b++)
                {
                    if (a * a + b * b == c * c)
                    {
                        pyth = true;
                    }
                }
                if (pyth == true) break;

            }

            int result = a * b * c;
            Console.WriteLine(result);

        }
    }
}
