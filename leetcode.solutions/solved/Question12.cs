namespace leetcode
{
    public static class Question12
    {
        public static string Solve(int num)
        {
            var bldr = new System.Text.StringBuilder();

            int thousands = num / 1000;
            num -= thousands * 1000;

            for (int i = 0; i < thousands; ++i)
            {
                bldr.Append('M');
            }

            int hundreds = num / 100;
            num -= hundreds * 100;

            HandleDigit(bldr, hundreds, 'C', 'D', 'M');

            int tens = num / 10;
            num -= tens * 10;

            HandleDigit(bldr, tens, 'X', 'L', 'C');

            int ones = num;

            HandleDigit(bldr, ones, 'I', 'V', 'X');

            return bldr.ToString();
        }

        private static void HandleDigit(System.Text.StringBuilder bldr, int val, char one, char five, char ten)
        {
            switch (val)
            {
                case 0: return;

                case 1: bldr.Append(one); return;
                case 2: bldr.Append(one); bldr.Append(one); return;
                case 3: bldr.Append(one); bldr.Append(one); bldr.Append(one); return;

                case 4: bldr.Append(one); bldr.Append(five); return;
                case 5: bldr.Append(five); return;

                case 6: bldr.Append(five); bldr.Append(one); return;
                case 7: bldr.Append(five); bldr.Append(one); bldr.Append(one); return;
                case 8: bldr.Append(five); bldr.Append(one); bldr.Append(one); bldr.Append(one); return;

                case 9: bldr.Append(one); bldr.Append(ten); return;
            }
        }

        // private static void HandleDigit(System.Text.StringBuilder bldr, int val, char one, char five, char ten)
        // {
        //     if (val < 4)
        //     {
        //         for (int i = 0; i < val; ++i)
        //         {
        //             bldr.Append(one);
        //         }
        //     }
        //     else if (val == 4)
        //     {
        //         bldr.Append(one);
        //         bldr.Append(five);
        //     }
        //     else if (val < 9)
        //     {
        //         bldr.Append(five);
        //         for (int i = 0; i < val - 5; ++i)
        //         {
        //             bldr.Append(one);
        //         }
        //     }
        //     else
        //     {
        //         bldr.Append(one);
        //         bldr.Append(ten);
        //     }
        // }
    }
}