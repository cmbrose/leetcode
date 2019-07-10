using System;
using System.Collections.Generic;

namespace leetcode
{
    public static class Question7
    {
        public static int Solve(int x)
        {
            const int MaxRev = int.MaxValue / 10;

            int rev = 0;

            if (x == int.MinValue)
            {
                return 0;
            }

            bool isNeg = x < 0;

            x = Math.Abs(x);

            while (x > 0)
            {
                if (rev > MaxRev)
                {
                    return 0;
                }
                
                int dig = x % 10;
                x /= 10;

                rev = rev * 10 + dig;
            }

            return isNeg ? -1 * rev : rev;
        }
    }
}