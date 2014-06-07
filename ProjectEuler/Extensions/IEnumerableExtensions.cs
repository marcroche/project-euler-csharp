using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Extensions
{
    public static class IEnumerableExtensions
    {
        public static void ForEach<T>(this IEnumerable<T> enumerable, Func<T, bool> breakOn)
        {
            foreach (var item in enumerable)
            {
                if (breakOn(item))
                {
                    break;
                }
            }
        }
    }
}
