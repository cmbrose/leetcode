namespace leetcode
{
    public static class Question8
    {
        public static int Solve(string str)
        {
            if (str.Length == 0)
            {
                return 0;
            }

            int idx = 0;

            while (idx < str.Length && str[idx] == ' ')
            {
                ++idx;
            }

            if (idx == str.Length)
            {
                return 0;
            }

            bool isPos = true;

            if (str[idx] == '-')
            {
                isPos = false;
                ++idx;
            }
            else if (str[idx] == '+')
            {
                ++idx;
            }
            else if (!char.IsDigit(str[idx]))
            {
                return 0;
            }

            long val = 0;
            while (idx < str.Length && char.IsDigit(str[idx]))
            {
                int nextVal = str[idx++] - '0';

                val = val * 10 + nextVal;

                if (isPos && val >= int.MaxValue)
                {
                    return int.MaxValue;
                }
                else if (!isPos && -val <= int.MinValue)
                {
                    return int.MinValue;
                }
            }

            return (int) (isPos ? val : -val);
        }
    }
}