using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            int num1 = 1;
            int num2 = 1;

            int sum = 0;
            while (num1 <= 4000000)
            {
                sum = num1 + num2;
                num1 = num2;
                num2 = sum;

                if (num2 % 2 == 0)
                {
                    list.Add(num2);
                }
            }
            int total = list.Sum();
            Console.WriteLine(total);

        }
    }
}
