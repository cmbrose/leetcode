namespace leetcode
{
    public static class Question53
    {
        public static int Solve(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                return 0;
            }

            int bestRun = nums[0];
            int prev = nums[0];

            for (int i = 1; i < nums.Length; ++i)
            {
                if (prev > 0)
                {
                    prev = prev + nums[i];
                }
                else
                {
                    prev = nums[i];
                }

                if (prev > bestRun)
                {
                    bestRun = prev;
                }
            }

            return bestRun;
        }
    }
}