using System.Text;
using System.Collections.Generic;

namespace leetcode
{
    public static class Question791
    {
        // Bucket sort
        public static string Solve(string S, string T)
        {
            if (string.IsNullOrEmpty(S) || string.IsNullOrEmpty(T))
            {
                return T;
            }

            StringBuilder bldr = new StringBuilder(T.Length);

            int[] counts = new int[26];

            foreach (char t in T)
            {
                counts[(int)(t - 'a')] += 1;
            }

            foreach (char s in S)
            {
                int cnt = counts[(int)(s - 'a')];
                for (int i = 0; i < cnt; ++i)
                {
                    bldr.Append(s);
                }
                counts[(int)(s - 'a')] = 0;
            }

            for (int i = 0; i < 26; ++i)
            {
                int cnt = counts[i];
                for (int j = 0; j < cnt; ++j)
                {
                    bldr.Append((char) (i + 'a'));
                }
            }

            return bldr.ToString();
        }

        // Use builtin sorting
        // public static string Solve(string S, string T)
        // {
        //     if (string.IsNullOrEmpty(S) || string.IsNullOrEmpty(T))
        //     {
        //         return T;
        //     }
            
        //     int[] ranks = new[] { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 };
                        
        //     for (int i = 0; i < S.Length; ++i)
        //     {
        //         char c = S[i];
        //         ranks[(int) (c - 'a')] = i;
        //     }

        //     char[] res = T.ToCharArray();

        //     Array.Sort(res, new CustomComparer(ranks));
            
        //     return new String(res);
        // }

        // private class CustomComparer : IComparer<char>
        // {
        //     private readonly int[] _ranks;

        //     public CustomComparer(int[] ranks)
        //     {
        //         _ranks = ranks;
        //     }

        //     public int Compare(char a, char b)
        //     {
        //         int ra = _ranks[(int)(a - 'a')];
        //         int rb = _ranks[(int)(b - 'a')];

        //         if (ra == -1)
        //         {
        //             return 1;
        //         }

        //         if (rb == -1)
        //         {
        //             return -1;
        //         }

        //         return ra - rb;
        //     }
        // }        
    }
}