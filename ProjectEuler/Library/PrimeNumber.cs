using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Library
{
    internal static class PrimeNumber
    {
        internal static bool IsPrime(long value)
        {
            if (value < 2)
            {
                return false;
            }

            if (Arithmetic.GetFactors(value).Count > 2)
            {
                return false;
            }

            return true;
        }

        internal static IEnumerable<long> Sieve(long max)
        {
            ICollection<long> primes = new Collection<long>();

            bool[] notCandidates = new bool[max];

            //for(int i = 0; i < max; i++)
            //{
            //    candidates[i] = true;
            //}

            notCandidates[0] = true;


            return primes;
        }

        internal static void AtkinsSieve()
        {
            //int totalCount = 0;
            //BitArray isPrime = new BitArray(topCandidate + 1);
            //int squareRoot = (int)Math.Sqrt(topCandidate);
            //int xSquare = 1, xStepsize = 3;
            //int ySquare = 1, yStepsize = 3;
            //int computedVal = 0;

            //for (int x = 1; x <= squareRoot; x++)
            //{
            //    ySquare = 1;
            //    yStepsize = 3;
            //    for (int y = 1; y <= squareRoot; y++)
            //    {
            //        computedVal = (xSquare << 2) + ySquare;

            //        if ((computedVal <= topCandidate) && (computedVal % 12 == 1 || computedVal % 12 == 5))
            //            isPrime[computedVal] = !isPrime[computedVal];

            //        computedVal -= xSquare;
            //        if ((computedVal <= topCandidate) && (computedVal % 12 == 7))
            //            isPrime[computedVal] = !isPrime[computedVal];

            //        if (x > y)
            //        {
            //            computedVal -= ySquare << 1;
            //            if ((computedVal <= topCandidate) && (computedVal % 12 == 11))
            //                isPrime[computedVal] = !isPrime[computedVal];
            //        }
            //        ySquare += yStepsize;
            //        yStepsize += 2;
            //    }
            //    xSquare += xStepsize;
            //    xStepsize += 2;
            //}

            //for (int n = 5; n <= squareRoot; n++)
            //{
            //    if (isPrime[n] == true)
            //    {
            //        int k = n * n;
            //        for (int z = k; z <= topCandidate; z += k)
            //            isPrime[z] = false;
            //    }
            //}

            //for (int i = 1; i < topCandidate; i++)
            //{
            //    if (isPrime[i]) totalCount++;
            //}
            //return (totalCount + 2); // 2 and 3 will be missed in Sieve Of Atkins 
        }
    }
}
