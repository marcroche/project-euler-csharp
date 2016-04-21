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
    }
}
