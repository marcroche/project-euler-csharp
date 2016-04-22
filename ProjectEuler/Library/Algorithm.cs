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
    }
}
