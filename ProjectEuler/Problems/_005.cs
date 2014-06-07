using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems
{
    /// <summary>
    /// 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
    /// 
    /// What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
    /// </summary>
    /// <answer>
    /// 232792560
    /// </answer>
    class _005
    {
        internal static void Run()
        {
            int currentNumber = 20;
            bool solution = false;

            while (solution == false)
            {
                bool flag = true;
                for (int i = 1; i <= 20; i++)
                {
                    if (currentNumber % i != 0)
                    {
                        flag = false;
                    }
                }

                if (flag == true)
                {
                    solution = true;
                }

                if (solution == true)
                {
                    Console.WriteLine("SOLUTION: " + currentNumber);
                }

                currentNumber++;
            }
        }
    }
}
