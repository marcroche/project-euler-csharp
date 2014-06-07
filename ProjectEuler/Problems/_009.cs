using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems
{
    /// <summary>
    /// A Pythagorean triplet is a set of three natural numbers, a b c, for which,
    /// a2 + b2 = c2
    /// For example, 32 + 42 = 9 + 16 = 25 = 52.
    /// 
    /// There exists exactly one Pythagorean triplet for which a + b + c = 1000.
    /// Find the product abc.
    /// </summary>
    /// <answer>
    /// 31875000
    /// </answer>
    class _009
    {
        internal static void Run()
        {
            for (int x = 1; x < 1000; x++)
            {
                for (int y = x + 1; y < 1000; y++)
                {
                    for (int z = y + 1; z < 1000; z++)
                    {
                        double left = Math.Pow(x, 2) + Math.Pow(y, 2);
                        double right = Math.Pow(z, 2);

                        if (left == right)
                        {
                            if (x + y + z == 1000)
                            {
                                Console.WriteLine("SOLUTION (" + x + " " + y + " " + z + "): " + (x * y * z));
                            }
                        }
                    }
                }
            }
        }
    }
}
