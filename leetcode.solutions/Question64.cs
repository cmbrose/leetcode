using leetcode.datastructures;

namespace leetcode
{
    public static class Question64
    {
        // Using a Heap and greedily selecting next
        // public static int Solve(int[][] grid)
        // {
        //     int m = grid.Length, n = grid[0].Length;

        //     var sums = new int[m, n];
        //     var seen = new bool[m, n];

        //     var heap = new MinHeap<WeightedPoint>((p1, p2) => p1.Weight - p2.Weight);

        //     heap.Push(new WeightedPoint { Weight = grid[0][0], X = 0, Y = 0, });

        //     while (true)
        //     {
        //         var p = heap.Pop();

        //         if (p.X == m - 1 && p.Y == n - 1)
        //         {
        //             return p.Weight;
        //         }

        //         if (seen[p.X, p.Y] && sums[p.X, p.Y] <= p.Weight)
        //         {
        //             continue;
        //         }

        //         seen[p.X, p.Y] = true;
        //         sums[p.X, p.Y] = p.Weight;

        //         if (p.X < m - 1)
        //         {
        //             heap.Push(new WeightedPoint { Weight = grid[p.X + 1][p.Y] + p.Weight, X = p.X + 1, Y = p.Y });
        //         }

        //         if (p.Y < n - 1)
        //         {
        //             heap.Push(new WeightedPoint { Weight = grid[p.X][p.Y + 1] + p.Weight, X = p.X, Y = p.Y + 1 });
        //         }
        //     }
        // }

        // private class WeightedPoint
        // {
        //     public int Weight { get;set; }
        //     public int X { get;set; }
        //     public int Y { get;set; }
        // }

        // DP with optimization to only store path of current row - O(m * n), O(m)
        public static int Solve(int[][] grid)
        {
            int m = grid.Length, n = grid[0].Length;

            var sums = new int[m];

            sums[m - 1] = grid[m - 1][n - 1];
            for (int i = m - 2; i >= 0; --i)
            {
                sums[i] = grid[i][n - 1] + sums[i + 1];
            }

            for (int y = n - 2; y >= 0; --y)
            {
                sums[m - 1] += grid[m - 1][y];

                for (int x = m - 2; x >= 0; --x)
                {                
                    int val = grid[x][y];

                    int pathRight = sums[x + 1];
                    int pathDown = sums[x];

                    int minPath = System.Math.Min(pathRight, pathDown);

                    sums[x] = minPath + val;
                }
            }

            return sums[0];
        }

        // DP, store entire grid of paths - O(m*n), O(m*n)
        // public static int Solve(int[][] grid)
        // {
        //     int m = grid.Length, n = grid[0].Length;

        //     var sums = new int[m, n];
        //     sums[m - 1, n - 1] = grid[m - 1][n - 1];

        //     for (int i = m - 2; i >= 0; --i)
        //     {
        //         sums[i, n - 1] = grid[i][n - 1] + sums[i + 1, n - 1];
        //     }

        //     for (int i = n - 2; i >= 0; --i)
        //     {
        //         sums[m - 1, i] = grid[m - 1][i] + sums[m - 1, i + 1];
        //     }

        //     for (int x = m - 2; x >= 0; --x)
        //     {
        //         for (int y = n - 2; y >= 0; --y)
        //         {
        //             int val = grid[x][y];
        //             int minPath = System.Math.Min(sums[x + 1, y], sums[x, y + 1]);

        //             sums[x, y] = minPath + val;
        //         }
        //     }

        //     return sums[0, 0];
        // }
    }
}