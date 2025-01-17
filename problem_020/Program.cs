using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace problem_020
{
    internal class Program
    {
        static BigInteger Factorial(int n)
        {
            BigInteger result = 1;

            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }

            return result;
        }
        private static void Main(string[] args)
        {
            int n = 100;
            BigInteger f = (Factorial(n));
            Console.WriteLine(f);
            string fact = f.ToString();
            int digsum = 0;
            foreach (char dig in fact)
            {
                if (char.IsDigit(dig))
                {
                    int digit = int.Parse(dig.ToString());
                    digsum += digit;
                }


            }
            Console.WriteLine(digsum);
        }
    }
}
