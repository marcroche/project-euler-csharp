using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Library
{
    internal static class TriangleNumber
    {
        internal static IEnumerable<int> GenerateNumbers()
        {
            int nextNumber = 0;
            int currentSum = 0; 
            while (true)
            {
                currentSum += ++nextNumber;
                yield return currentSum;
            }
        }
    }
}
