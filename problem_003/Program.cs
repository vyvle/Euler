using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long num = 600851475143;

            for (int i = 2; i < num; i++)
            {
                if (num % i == 0) 
                {
                    bool isitprime = true;
                    for (int j = 2; j < i; j++) 
                    {
                        if (i % j == 0) 
                        {
                            isitprime = false; 
                            break;
                        }
                    }
                    if (isitprime)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
    }
}
