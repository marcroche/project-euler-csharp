using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems
{
    /// <summary>
    /// By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
    /// 
    /// What is the 10,001st prime number?
    /// </summary>
    /// <<answer>
    /// 104743
    /// </answer>
    class _007
    {
        internal static void Run()
        {
            List<long> primes = new List<long>();
            bool solution = false;
            long counter = 1;

            while (solution == false)
            {
                counter++;

                if (Library.IsPrime(counter))
                {
                    Console.WriteLine(counter);

                    primes.Add(counter);

                    if (primes.Count == 10001)
                    {
                        solution = true;
                    }
                }
            }

            Console.WriteLine("SOLUTION: " + counter);
        }
    }
}
