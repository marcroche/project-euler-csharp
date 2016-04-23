using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Library
{
    internal static class Algorithm
    {
        internal static IEnumerable<long> CollatzSequence(long seed)
        {
            IList<long> sequence = new List<long>();
            sequence.Add(seed);

            long currentValue = seed;
            
            while (currentValue != 1)
            { 
                if (currentValue % 2 == 0)
                {
                    currentValue = currentValue / 2;
                }
                else
                {
                    currentValue = 3 * currentValue + 1;
                }
                sequence.Add(currentValue);
            }

            return sequence;
        }

        internal static long CollatzSequenceChainLength(long seed)
        {
            long length = 1;

            long currentValue = seed;

            while (currentValue != 1)
            {
                if (currentValue % 2 == 0)
                {
                    currentValue = currentValue / 2;
                }
                else
                {
                    currentValue = 3 * currentValue + 1;
                }
                length++;
            }

            return length;
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
