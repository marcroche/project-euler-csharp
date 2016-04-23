using System;
using ProjectEuler.Library;

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
    class _0010
    {
        internal static void Run()
        {
            long sum = 0;
            for (int i = 0; i < 2000000; i++)
            {
                if (PrimeNumber.IsPrime(i))
                {
                    sum += i;
                }
            }

            Console.WriteLine("SOLUTION: " + sum);
        }
    }
}
