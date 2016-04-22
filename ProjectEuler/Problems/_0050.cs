using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace ProjectEuler.Problems
{
    /// <summary>
    /// The prime 41, can be written as the sum of six consecutive primes:
    /// 41 = 2 + 3 + 5 + 7 + 11 + 13
    /// This is the longest sum of consecutive primes that adds to a prime below one-hundred.
    ///
    /// The longest sum of consecutive primes below one-thousand that adds to a prime, contains 21 terms, and is equal to 953.
    ///
    /// Which prime, below one-million, can be written as the sum of the most consecutive primes?
    /// </summary>
    /// <answer>
    /// 997651
    /// </answer>
    class _0050
    {
        internal static void Run()
        {
            List<long> primesList = new List<long>();

            for (int i = 0; i < 1000000; i++)
            {
                if (ProjectEuler.Library.Library.IsPrime(i))
                {
                    primesList.Add(i);
                }
            }


            long[] primes = primesList.ToArray();

            Stopwatch s = new Stopwatch();
            s.Start();

            int number = 0;
            long value = 0;

            int consec = 1;

            while (consec < primes.Length)
            {
                //Console.WriteLine(consec);

                for (int c = 0; c + consec < primes.Length; c++)
                {
                    long sum = 0;
                    bool isBreak = false;
                    for (int i = 0; i < consec && c + i < primes.Length; i++)
                    {
                        sum += primes[c + i];

                        if (sum >= 1000000)
                        {
                            isBreak = true;
                            break;
                        }
                    }

                    if (isBreak || sum >= 1000000)
                    {
                        break;
                    }

                    if (primes.Contains(sum))
                    {
                        if (consec > number)
                        {
                            number = consec;
                            value = sum;
                        }
                        break;
                    }
                }
                consec++;
            }

            //int number = 0;
            //long value = 0;

            //for (int i = 0; i < primes.Length; i++)
            //{
            //    Console.WriteLine(i);

            //    int numberOfPrimes = 0;
            //    long sum = 0;

            //    // number to iterate iterate primes
            //    for (int z = i; z < primes.Length; z++)
            //    {
            //        numberOfPrimes++;
            //        sum += primes[z];

            //        if (sum >= 1000000)
            //        {
            //            break;
            //        }

            //        if (primes.Contains(sum))
            //        {
            //            if (numberOfPrimes > number)
            //            {
            //                number = numberOfPrimes;
            //                value = sum;
            //            }
            //        }
            //    }
            //}

            s.Stop();

            double time = s.ElapsedMilliseconds / 1000.0d;
            Console.WriteLine("SOLUTION: (" + time + ") " + value);
        }
    }
}
