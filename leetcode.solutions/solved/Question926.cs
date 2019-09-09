namespace leetcode
{
    public static class Question926
    {
        public static int Solve(string S)
        {
            if (string.IsNullOrEmpty(S))
            {
                return 0;
            }

            int[] prefixSums = new int[S.Length + 1];

            for (int i = 0; i < S.Length; ++i)
            {
                prefixSums[i + 1] = prefixSums[i] + (S[i] - '0');
            }

            int min = int.MaxValue;

            for (int i = 0; i <= S.Length; ++i)
            {
                int delta = prefixSums[i] + S.Length - i - (prefixSums[S.Length] - prefixSums[i]);

                if (delta < min)
                {
                    min = delta;
                }
            }

            return min;
        }
    }
}