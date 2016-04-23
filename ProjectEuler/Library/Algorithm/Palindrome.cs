using System.Linq;

namespace ProjectEuler.Library.Algorithm
{
    internal static class Palindrome
    {
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
    }
}
