namespace ProjectEuler.Library.Algorithm
{
    internal static class Fibonacci
    {
        internal static long RecursiveFibonacci(long seed)
        {
            if (seed <= 1)
            {
                return 1;
            }

            long value = RecursiveFibonacci(seed - 1) + RecursiveFibonacci(seed - 2);

            return value;
        }
    }
}
