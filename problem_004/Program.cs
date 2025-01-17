using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 100; i < 1000; i++)
            {
                for (int j = 100; j < 1000; j++)
                {
                    int n = j * i;

                    List<int> seznam = new List<int>();

                    for (int m = 1; m <= 6; m++)
                    {
                        int a = n % 10;
                        n /= 10;
                        seznam.Add(a);
                    }

                    List<int> reverse = new List<int>();
                    reverse.AddRange(seznam);
                    seznam.Reverse();

                    if (seznam.SequenceEqual(reverse))
                    {
                        Console.WriteLine(string.Join(",", seznam));
                    }

                }
            }
        }
    }
}
