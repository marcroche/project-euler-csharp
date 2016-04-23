using ProjectEuler.Library;
using ProjectEuler.Library.Algorithm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems
{
    /// <summary>
    /// The following iterative sequence is defined for the set of positive integers
    // n → n/2 (n is even)
    // n → 3n + 1 (n is odd)

    // Using the rule above and starting with 13, we generate the following sequence:
    // 13 → 40 → 20 → 10 → 5 → 16 → 8 → 4 → 2 → 1
    // It can be seen that this sequence (starting at 13 and finishing at 1) contains 10 terms. Although it has not been proved yet (Collatz Problem), it is thought that all starting numbers finish at 1.

    // Which starting number, under one million, produces the longest chain?
    /// </summary>
    /// <answer>
    /// 
    /// </answer>
    internal static class _0014
    {
        internal static long Run()
        {
            // number, chain length
            Tuple<long, long> currentLongest = new Tuple<long, long>(1, 1);

            for(int i = 1; i < 1000000; i++)
            {
                long length =  Collatz.CollatzSequenceChainLength(i);

                if (length > currentLongest.Item2)
                {
                    currentLongest = new Tuple<long, long>(i, length);
                }
            }

            return currentLongest.Item1;
        }
    }
}
