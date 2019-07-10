using System.Collections.Generic;

namespace leetcode
{
    public static class Question15
    {
        public static IList<IList<int>> Solve(int[] nums)
        {
            System.Array.Sort(nums);

            var ret = new List<IList<int>>();

            for (int i = 0; i < nums.Length - 2; ++i)
            {
                if (i > 0 && nums[i] == nums[i - 1])
                {
                    continue;
                }

                if (nums[i] > 0)
                {
                    break;
                }

                int target = -nums[i];

                int lo = i + 1, hi = nums.Length - 1;
                while (lo < hi)
                {
                    int test = nums[lo] + nums[hi];

                    if (test == target)
                    {
                        ret.Add(new List<int>{ nums[i], nums[lo], nums[hi] });
                        ++lo;
                        --hi;
                    }
                    else if (test < target) // Too small, lo needs to be bigger
                    {
                        ++lo;
                    }
                    else // Too big, hi needs to be smaller
                    {
                        --hi;
                    }
                    
                    while (lo > i + 1 && lo < hi && nums[lo] == nums[lo - 1])
                    {
                        ++lo;
                    }

                    while (hi < nums.Length - 1 && lo < hi && nums[hi] == nums[hi + 1])
                    {
                        --hi;
                    }
                }
            }

            return ret;            
        }

        // Super awful caching - O(N^2)
        // public static IList<IList<int>> Solve(int[] nums)
        // {
        //     var ret = new List<IList<int>>();

        //     var seen = new Dictionary<int, HashSet<int>>();

        //     var twoSums = new Dictionary<int, int>();

        //     for (int i = 0; i < nums.Length - 2; ++i)
        //     {         
        //         twoSums.Clear();

        //         int n1 = nums[i];

        //         for (int j = i + 1; j < nums.Length - 1; ++j)
        //         {                    
        //             int n2 = nums[j];

        //             int twoSum = n1 + n2;

        //             if (!twoSums.ContainsKey(twoSum))
        //             {
        //                 twoSums[n1 + n2] = j;
        //             }                    
        //         }

        //         for (int j = i + 2; j < nums.Length; ++j)
        //         {
        //             int n3 = nums[j];
                    
        //             if (seen.TryGetValue(n1, out var cache) && cache.Contains(n3))
        //             {
        //                 continue;
        //             }

        //             if (twoSums.TryGetValue(-n3, out var idx) && idx < j)
        //             {
        //                 int n2 = -(n1 + n3);

        //                 ret.Add(new List<int> { n1, n2, n3 });
        //                 UpdateCache(seen, n1, n2, n3);
        //             }
        //         }
        //     }

        //     return ret;
        // }

        // private static void UpdateCache(Dictionary<int, HashSet<int>> cache, int n1, int n2, int n3)
        // {
        //     if (!cache.TryGetValue(n1, out var cache1))
        //     {
        //         cache[n1] = cache1 = new HashSet<int>();
        //     }
        //     cache1.Add(n2);
        //     cache1.Add(n3);

        //     if (!cache.TryGetValue(n2, out var cache2))
        //     {
        //         cache[n2] = cache2 = new HashSet<int>();
        //     }
        //     cache2.Add(n3);
        //     cache2.Add(n1);

        //     if (!cache.TryGetValue(n3, out var cache3))
        //     {
        //         cache[n3] = cache3 = new HashSet<int>();
        //     }
        //     cache3.Add(n2);
        //     cache3.Add(n1);
        // }
    }
}