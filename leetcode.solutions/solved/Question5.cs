namespace leetcode
{
    public static class Question5
    {
        public static string Solve(string s)
        {
            if (s == "")
            {
                return "";
            }

            int maxStart = 0, maxEnd = 0;

            for (int i = 0; i < s.Length; ++i)
            {
                bool isOddOK = true;
                bool isEvenOK = i < s.Length - 1 && s[i] == s[i + 1];

                if (isEvenOK && 2 > maxEnd - maxStart + 1)
                {
                    maxStart = i;
                    maxEnd = i + 1;
                }

                for (int d = 1; isEvenOK || isOddOK; ++d)
                {
                    if (isOddOK)
                    {
                        if (i - d >= 0 && i + d < s.Length && s[i - d] == s[i + d])
                        {
                            if (d * 2 + 1 > maxEnd - maxStart + 1)
                            {
                                maxStart = i - d;
                                maxEnd = i + d;
                            }
                        }
                        else
                        {
                            isOddOK = false;
                        }
                    }

                    if (isEvenOK)
                    {
                        if (i - d >= 0 && i + d + 1 < s.Length && s[i - d] == s[i + d + 1])
                        {
                            if (d * 2 + 2 > maxEnd - maxStart + 1)
                            {
                                maxStart = i - d;
                                maxEnd = i + d + 1;
                            }
                        }
                        else
                        {
                            isEvenOK = false;
                        }
                    }
                }
            }

            return s.Substring(maxStart, maxEnd - maxStart + 1);
        }

        // Brute force
        // public static string Solve(string s)
        // {
        //     string maxPalindrome = "";

        //     for (int i = 0; i < s.Length; ++i)
        //     {
        //         for (int j = i + maxPalindrome.Length; j < s.Length; ++j)
        //         {
        //             if (IsPalindromeAt(s, i, j))
        //             {
        //                 maxPalindrome = s.Substring(i, j - i + 1);
        //             }
        //         }
        //     }

        //     return maxPalindrome;
        // }

        private static bool IsPalindromeAt(string s, int start, int end)
        {
            while (start < end)
            {
                if (s[start++] != s[end--])
                {
                    return false;
                }
            }

            if (start == end)
            {
                return s[start] == s[end];
            }

            return true;
        }       
    }
}