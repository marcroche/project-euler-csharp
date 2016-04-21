using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler.Library
{
    class Library
    {
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

        internal static bool IsPalindrome(string number)
        {
            int startEndpoint;
            int endStartPoint;
            string start;
            string end;

            startEndpoint = number.Length / 2;
            endStartPoint = number.Length % 2 == 0 ? number.Length / 2 : number.Length / 2 + 1;

            start = number.Substring(0, startEndpoint);
            end = new string(number
                .Substring(endStartPoint)
                .Reverse()
                .ToArray());

            if (start == end)
            {
                return true;
            }

            return false;
        }

        internal static bool IsPrime(long value)
        {
            if (value < 2)
            {
                return false;
            }

            if (GetFactors(value).Count > 2)
            {
                return false;
            }

            return true;
        }

        internal static long RecursiveFibonacci(long seed)
        {
            Console.WriteLine(seed);
            if (seed <= 1)
            {
                return 1;
            }

            long value = RecursiveFibonacci(seed - 1) + RecursiveFibonacci(seed - 2);
            Console.WriteLine(value);
            return value;
        }
    }
}
