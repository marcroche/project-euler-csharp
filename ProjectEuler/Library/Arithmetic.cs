using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Library
{
    internal static class Arithmetic
    {
        internal static IEnumerable<int> GetDivisors(int number)
        {
            IList<int> divisors = new List<int>();

            for(int i = 1; i <= number; i++)
            {
                if(number % i == 0)
                {
                    divisors.Add(i);
                }
            }
            return divisors;
        }

        internal static List<long> GetFactors(long value)
        {
            List<long> factors = new List<long>();

            double temp = Math.Sqrt(value);
            int sqrt = (int)temp;
            bool isPerfectSquare = temp % 1 == 0;

            for (long i = 1; i <= sqrt; i++)
            {
                if (value % i == 0)
                {
                    factors.Add(i);
                }
            }

            List<long> others = new List<long>();

            factors.ForEach(x =>
            {
                if (!(isPerfectSquare && x == sqrt))
                {
                    others.Add(value / x);
                }
            });

            factors.AddRange(others);

            return factors;
        }
    }
}
