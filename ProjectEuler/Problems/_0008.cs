﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems
{
    /// <summary>
    /// Find the greatest product of five consecutive digits in the 1000-digit number.
    /// </summary>
    /// <answer>
    /// 40824
    /// </answer>
    class _0008
    {
        internal static void Run()
        {
            string largeNumber = @"73167176531330624919225119674426574742355349194934
                                    96983520312774506326239578318016984801869478851843
                                    85861560789112949495459501737958331952853208805511
                                    12540698747158523863050715693290963295227443043557
                                    66896648950445244523161731856403098711121722383113
                                    62229893423380308135336276614282806444486645238749
                                    30358907296290491560440772390713810515859307960866
                                    70172427121883998797908792274921901699720888093776
                                    65727333001053367881220235421809751254540594752243
                                    52584907711670556013604839586446706324415722155397
                                    53697817977846174064955149290862569321978468622482
                                    83972241375657056057490261407972968652414535100474
                                    82166370484403199890008895243450658541227588666881
                                    16427171479924442928230863465674813919123162824586
                                    17866458359124566529476545682848912883142607690042
                                    24219022671055626321111109370544217506941658960408
                                    07198403850962455444362981230987879927244284909188
                                    84580156166097919133875499200524063689912560717606
                                    05886116467109405077541002256983155200055935729725
                                    71636269561882670428252483600823257530420752963450"
                                    .Replace("\r", "")
                                    .Replace("\n", "")
                                    .Replace(" ", "");

            if(largeNumber.Length != 1000)
            {
                throw new Exception("Invalid Length");
            }

            List<long> products = new List<long>();
            int start = 0;

            while (start + 5 < 1000)
            {
                string values = largeNumber.Substring(start, 5);

                values.ToCharArray();
                int product = 1;
                foreach (char c in values)
                {
                    product *= int.Parse(c.ToString());
                }

                products.Add(product);

                start++;
            }

            Console.WriteLine("SOLUTION: " + products.OrderByDescending(x => x).First());
        }
    }
}