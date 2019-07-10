namespace leetcode
{
    public class Question9
    {
        public static bool Solve(int x)
        {
            if (x < 0)
            {
                return false;
            }
            
            if (x < 10)
            {
                return true;
            }
            
            if (x % 10 == 0)
            {
                return false;
            }            

            int rev = 0;

            while (x > rev)
            {
                rev = rev * 10 + x % 10;

                // Handles odd length numbers - the middle digit is in both numbers
                if (rev == x)
                {
                    return true;
                }

                x /= 10;

                // Handles even length numbers
                if (rev == x)
                {
                    return true;
                }
            }

            return false;
        }

        // Covert to string
        // public static bool Solve(int x)
        // {
        //     if (x < 0)
        //     {
        //         return false;
        //     }

        //     if (x < 10)
        //     {
        //         return true;
        //     }

        //     var str = x.ToString();

        //     int lo = 0, hi = str.Length - 1;

        //     while (lo < hi)
        //     {
        //         if (str[lo++] != str[hi--])
        //         {
        //             return false;
        //         }
        //     }

        //     return true;
        // }
    }
}