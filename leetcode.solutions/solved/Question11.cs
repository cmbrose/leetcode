namespace leetcode
{
    public static class Question11
    {
        public static int Solve(int[] height)
        {
            int max = -1;
            int lo = 0, hi = height.Length - 1;
            
            while (lo < hi) {
                int width = hi - lo;
                int h1 = height[lo], h2 = height[hi];
                int test;
                if (h1 < h2) {
                    test = width * h1;
                    ++lo;
                } else {
                    test = width * h2;
                    --hi;
                }
                
                max = max < test ? test : max;
            }
            
            return max;
        }
    }
}