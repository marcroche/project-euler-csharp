using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems
{
    /// <summary>
    /// The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
    ///  
    /// Find the sum of all the primes below two million.
    /// </summary>
    /// <answer>
    /// 142913828922
    /// </answer>
    class _010
    {
        internal static void Run()
        {
            long sum = 0;
            for (int i = 0; i < 2000000; i++)
            {
                if (Library.IsPrime(i))
                {
                    sum += i;
                }
            }

            Console.WriteLine("SOLUTION: " + sum);
        }
    }
}
