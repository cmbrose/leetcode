using System.Collections.Generic;

namespace leetcode
{
    public static class Question96
    {
        public static int Solve(int n)
        {
            return NumTrees(n);
        }

        public static int NumTrees(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }

            int[] cache = new int[n + 1];
            cache[0] = cache[1] = 1;

            for (int i = 2; i <= n; ++i)
            {
                cache[i] = 0;
                for (int j = 1; j <= i / 2; ++j)
                {
                    cache[i] += cache[j - 1] * cache[i - j];
                }

                cache[i] *= 2;

                if ((i & 1) == 1)
                {
                    cache[i] += cache[i / 2] * cache[i / 2];
                }
            }

            return cache[n];
        }

        // Recursion
        // public static int NumTrees(int n)
        // {
        //     if (cache.TryGetValue(n, out int nt))
        //     {
        //         return nt;
        //     }

        //     int sum = 0;
        //     // for (int i = 1; i <= n; ++i)
        //     // {
        //     //     sum += NumTrees(i - 1) * NumTrees(n - i);
        //     // }

        //     for (int i = 1; i <= n / 2; ++i)
        //     {
        //         sum += NumTrees(i - 1) * NumTrees(n - i);
        //     }

        //     sum *= 2;

        //     if ((n & 1) == 1) // odd
        //     {
        //         int val = NumTrees(n / 2);
        //         sum += val * val;
        //     }            

        //     cache[n] = sum;
        //     return sum;
        // }

        // private static Dictionary<int, int> cache = new Dictionary<int, int>
        // {
        //     { 0, 1},
        //     { 1, 1},
        // };
    }
}