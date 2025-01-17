using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_007
{
    internal class Program
    {
        public static bool chkprime(int num)
        {
            for (int i = 2; i < num; i++)
                if (num % i == 0)
                    return false;
            return true;
        }

        static void Main(string[] args)
        {
            int counter = 0;

            for (int i = 2; i < 1000000; i++)
            {
                if (chkprime(i))
                {
                    counter++;
                }

                if (counter == 10001)
                {
                    Console.WriteLine(i);
                    break;
                }

            }
        }
    }
}
