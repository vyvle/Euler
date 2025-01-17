using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace problem_016
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BigInteger mybase = BigInteger.Pow(2, 1000);
            Console.WriteLine(mybase);
            string sum = Convert.ToString(mybase);
            Console.WriteLine(sum);
            int digsum = 0;
            foreach (char dig in sum)
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
