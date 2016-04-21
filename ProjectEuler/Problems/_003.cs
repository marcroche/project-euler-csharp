using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectEuler.Extensions;

namespace ProjectEuler.Problems
{
    /// <summary>
    /// The prime factors of 13195 are 5, 7, 13 and 29.
    /// 
    /// What is the largest prime factor of the number 600851475143 ?
    /// </summary>
    /// <answer>
    /// 6857
    /// </answer>
    public class _003
    {
        public static long Run()
        {
            List<long> factors = ProjectEuler.Library.Library.GetFactors(600851475143);
            long value = 0;

            factors.OrderByDescending(x => x).ToList().ForEach((x) =>
            {
                if (ProjectEuler.Library.Library.IsPrime(x))
                {
                    value = x;
                    return true;
                }
                return false;
            });

            return value;
        }
    }
}
