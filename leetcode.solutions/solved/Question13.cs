namespace leetcode
{
    public static class Question13
    {
        public static int Solve(string s)
        {
            int val = 0;
            int prevDig = int.MaxValue;

            for (int i = 0; i < s.Length; ++i)
            {
                int cur = ValueOfDigit(s[i]);

                if (prevDig < cur)
                {
                    val += cur - prevDig - prevDig;
                }
                else
                {
                    val += cur;
                }

                prevDig = cur;
            }

            return val;
        }

        private static int ValueOfDigit(char c)
        {
            switch (c)
            {
                case 'I': return 1;
                case 'V': return 5;
                case 'X': return 10;
                case 'L': return 50;
                case 'C': return 100;
                case 'D': return 500;
                case 'M': return 1000;
            }

            throw new System.Exception($"Symbol {c} is not a Roman Numeral");
        }
    }
}