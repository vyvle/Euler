using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_010
{
    internal class Program
    {
        public static bool chkprime(long number)
        {
            if (number == 1)
                return false;
            if (number == 2)
                return true;
            int highest = (int)Math.Sqrt(number);
            for (int i = 2; i <= highest; i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }

        static void Main(string[] args)
        {
            long num = 0;
            for (long i = 1; i < 2000000; i++)
            {
                if (chkprime(i) == true)
                {
                    num += i;
                    //Console.WriteLine(i);
                }

            }

            Console.WriteLine(num);
        }
    }
}
