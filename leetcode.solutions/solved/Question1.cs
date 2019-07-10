using System;
using System.Collections.Generic;

namespace leetcode
{
    public static class Question1
    {
        // Build diff lookup while searching - O(n), O(n)
        public static int[] Solve(int[] nums, int target)
        {
            var diffs = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; ++i)
            {
                var num = nums[i];
                if (diffs.TryGetValue(num, out var idx))
                {
                    return new[] { idx, i };
                }
                else
                {
                    diffs[target - num] = i;
                }
            }

            throw new System.InvalidOperationException($"Expected a valid solution.  Input was: [ {string.Join(", ", nums)} ], {target}");
        }

        // Pre-cache diff lookup - O(n), O(n)
        // public static int[] Solve(int[] nums, int target)
        // {
        //     var diffs = new Dictionary<int, int>(nums.Length);
        //     for (int i = 0; i < nums.Length; ++i)
        //     {
        //         var num = nums[i];

        //         var diff = target - num;

        //         if (diffs.ContainsKey(diff))
        //         {
        //             if (diff + diff == target)
        //             {
        //                 return new int[] {diffs[diff], i};
        //             }
        //         }
        //         else
        //         {
        //             diffs[diff] = i;
        //         }
        //     }

        //     for (int i = 0; i < nums.Length; ++i)
        //     {
        //         var num = nums[i];
        //         if (diffs.TryGetValue(num, out var idx) && idx != i)
        //         {
        //             return new[] { i, idx };
        //         }
        //     }

        //     throw new System.InvalidOperationException($"Expected a valid solution.  Input was: [ {string.Join(", ", nums)} ], {target}");
        // }

        // Sort + Lo-Hi - O(n), O(n)
        // public static int[] Solve(int[] nums, int target)
        // {
        //     var source = new Dictionary<int, int>();
        //     for (int i = 0; i < nums.Length; ++i)
        //     {
        //         var num = nums[i];
        //         if (source.ContainsKey(num))
        //         {
        //             if (num + num == target)
        //             {
        //                 return new int[] {source[num], i};
        //             }
        //         }
        //         else
        //         {
        //             source[num] = i;
        //         }
        //     }

        //     Array.Sort(nums);

        //     int lo = 0, hi = nums.Length - 1;

        //     while (lo < hi)
        //     {
        //         int nLo = nums[lo];
        //         int nHi = nums[hi];

        //         int sum = nLo + nHi;

        //         if (sum == target)
        //         {
        //             var sLo = source[nLo];
        //             var sHi = source[nHi];

        //             return sLo < sHi
        //                 ? new[] {sLo, sHi}
        //                 : new[] {sHi, sLo};
        //         }
        //         else if (sum < target)
        //         {
        //             ++lo;
        //         }
        //         else
        //         {
        //             --hi;
        //         }
        //     }

        //     throw new System.InvalidOperationException($"Expected a valid solution.  Input was: [ {string.Join(", ", nums)} ], {target}");
        // }

        // Brute Force - O(n^2), O(1)
        // public static int[] Solve(int[] nums, int target)
        // {
        //     for (int i = 0; i < nums.Length - 1; ++i)
        //     {
        //         int partial = target - nums[i];
        //         for (int j = i + 1; j < nums.Length; ++j)
        //         {
        //             if (nums[j] == partial)
        //             {
        //                 return new[] { i, j };
        //             }
        //         }
        //     }

        //     throw new System.InvalidOperationException($"Expected a valid solution.  Input was: [ {string.Join(", ", nums)} ], {target}");
        // }
    }
}