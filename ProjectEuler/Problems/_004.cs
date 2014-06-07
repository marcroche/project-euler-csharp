using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems
{
    /// <summary>
    /// A palindromic number reads the same both ways. 
    /// The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 99.
    /// 
    /// Find the largest palindrome made from the product of two 3-digit numbers.
    /// </summary>
    /// <answer>
    /// 906609
    /// </answer>
    class _004
    {
        internal static void Run()
        {
            List<long> palindromes = new List<long>();

            for (int i = 999; i > 99; i--)
            {
                for (int j = 999; j > 99; j--)
                {
                    long temp = i * j;

                    if (Library.IsPalindrome(temp.ToString()))
                    {
                        palindromes.Add(temp);
                    }
                }
            }

            Console.WriteLine("SOLUTION: " + palindromes.OrderByDescending(x => x).First());
        }
    }
}
