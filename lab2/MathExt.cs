using System;

namespace lab2
{
    public static class MathExt
    {
        public static int Combinations(int n, int k)
        {
            ulong Factorial(ulong x)
            {
                if (x < 2)
                    return 1;
                return x * Factorial(x - 1);
            }

            return Convert.ToInt32(Factorial((ulong)n) / Factorial((ulong)k) / Factorial((ulong)(n - k)));
        }
    }
}