using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems
{
    /// <summary>
    /// The sum of the squares of the first ten natural numbers is,
    /// 12 + 22 + ... + 102 = 385
    /// 
    /// The square of the sum of the first ten natural numbers is,
    /// (1 + 2 + ... + 10)2 = 552 = 3025
    /// 
    /// Hence the difference between the sum of the squares of the first ten natural numbers 
    /// and the square of the sum is 3025 385 = 2640.
    /// 
    /// Find the difference between the sum of the squares of the first one hundred natural numbers 
    /// and the square of the sum.
    /// </summary>
    /// <answer>
    /// 25164150
    /// </answer>
    class _006
    {
        internal static void Run()
        {
            int total = 0;
            for (int i = 1; i <= 100; i++)
            {
                total += (int)Math.Pow(i, 2);
            }

            int total2 = 0;
            for (int i = 1; i <= 100; i++)
            {
                total2 += i;
            }

            Console.WriteLine("SOLUTION: " + ((int)Math.Pow(total2, 2) - total));
        }
    }
}
