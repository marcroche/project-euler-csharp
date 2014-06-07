using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler.Problems
{
    /// <summary>
    /// If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. 
    /// The sum of these multiples is 23.
    /// Find the sum of all the multiples of 3 or 5 below 1000.
    /// </summary>
    /// <answer>
    /// 233168
    /// </answer>
    public class _001
    {
        public static int Run()
        {
            List<int> solves = new List<int>();

            for (int i = 1; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    solves.Add(i);
                }
            }

            return solves.Sum(x => x);
        }
    }
}