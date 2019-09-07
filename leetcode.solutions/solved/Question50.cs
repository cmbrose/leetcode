namespace leetcode
{
    public static class Question50
    {

        public static double Solve(double x, int n) 
        {
            if (x == 0 || x == 1)
            {
                return x;
            }

            if (n == 0)
            {
                return 1;
            }

            if (n == int.MinValue)
            {
                return x * Solve(x, n + 1);
            }

            if (n < 0)
            {
                x = 1 / x;
                n = -n;
            }

            return SolveRec(x, n);
        }

        private static double SolveRec(double x, int n) 
        {
            if (n == 1)
            {
                return x;
            }

            if (n == 2)
            {
                return x * x;
            }

            if (n == 3)
            {
                return x * x * x;
            }

            bool isOdd = (n & 1) == 1;

            int half = n / 2;

            double halfPow = SolveRec(x, half);
            return isOdd ? halfPow * halfPow * x : halfPow * halfPow;
        }

        // Brute Force
        // public static double Solve(double x, int n) 
        // {
        //     if (n == 0)
        //     {
        //         return 1;
        //     }

        //     if (n < 0)
        //     {
        //         x = 1 / x;
        //         n = -n;
        //     }

        //     if (n == 1)
        //     {
        //         return x;
        //     }

        //     double res = x;

        //     for (int i = 1; i < n; ++i)
        //     {
        //         res *= x;
        //     }

        //     return res;
        // }
    }
}