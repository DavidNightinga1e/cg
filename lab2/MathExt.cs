namespace lab2
{
    public static class MathExt
    {
        public static int Combinations(int n, int k)
        {
            int Factorial(int x)
            {
                if (x < 2)
                    return 1;
                return x * Factorial(x - 1);
            }

            return Factorial(n) / Factorial(k) / Factorial(n - k);
        }
    }
}