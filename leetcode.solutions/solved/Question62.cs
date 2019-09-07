using System;
using System.Collections.Generic;

namespace leetcode
{
    public static class Question62
    {
        public static int Solve(int m, int n)
        {
            var dists = new int[m, n];
            dists[m - 1, n - 1] = 1;

            for (int x = m - 1; x >= 0; --x)
            {
                for (int y = n - 1; y >= 0; --y)
                {                
                    var refPoint = GetReflectedPoint(x, y, m, n);
                    int rx = refPoint.Item1, ry = refPoint.Item2;

                    if (rx < m && rx >= 0 && ry < n && ry >= 0 && dists[rx, ry] != 0)
                    {
                        dists[x, y] = dists[rx, ry];
                        continue;
                    }

                    var goRight = x < m - 1 ? dists[x + 1, y] : 0;
                    var goDown  = y < n - 1 ? dists[x, y + 1] : 0;

                    dists[x, y] = goRight + goDown;
                }
            }

            return dists[0, 0];
        }

        private static Tuple<int, int> GetReflectedPoint(int x, int y, int m, int n)
        {
            int d = m - n;
            int y45 = x - d;
            int dy = y - y45;
            return Tuple.Create(x + dy, y - dy);
        }
    }
}