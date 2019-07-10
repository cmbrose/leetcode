namespace leetcode
{
    public static class Question31
    {
        public static void Solve(int[] nums)
        {
            if (nums == null || nums.Length <= 1)
            {
                return;
            }

            int i = nums.Length - 2;

            while (i >= 0 && nums[i] >= nums[i + 1])
            {
                --i;
            }

            if (i >= 0)
            {
                int j = i + 1;
                while (j < nums.Length && nums[j] > nums[i])
                {
                    ++j;
                }

                Swap(nums, i, j - 1);
            }

            Reverse(nums, i + 1);
        }        

        private static void Reverse(int[] nums, int start)
        {
            int end = nums.Length - 1;
            while (start < end)
            {
                Swap(nums, start++, end--);
            }
        }

        private static void Swap(int[] nums, int i, int j)
        {
            int temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }
    }
}