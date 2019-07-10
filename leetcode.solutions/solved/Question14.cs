namespace leetcode
{
    public static class Question14
    {
        // Select min and max and compare only them
        // public static string Solve(string[] strs)
        // {
        //     if (strs.Length == 0)
        //     {
        //         return "";
        //     }

        //     if (strs.Length == 1) 
        //     {
        //         return strs[0];
        //     }

        //     var min = strs[0];
        //     var max = strs[0];

        //     for (int i = 1; i < strs.Length; ++i)
        //     {
        //         if (min.CompareTo(strs[i]) > 0) 
        //         {
        //             min = strs[i];
        //         }

        //         if (max.CompareTo(strs[i]) < 0)
        //         {
        //             max = strs[i];
        //         }
        //     }

        //     int idx = 0;
        //     for (idx = 0; idx < min.Length && idx < max.Length && min[idx] == max[idx]; ++idx)
        //         ;

        //     return min.Substring(0, idx);
        // }

        // Brute force
        public static string Solve(string[] strs)
        {
            if (strs.Length == 0)
            {
                return "";
            }

            var lead = strs[0];

            for (int i = 0; i < lead.Length; ++i)
            {
                for (int j = 1; j < strs.Length; ++j)
                {
                    var test = strs[j];

                    if (test.Length <= i || test[i] != lead[i])
                    {
                        return lead.Substring(0, i);
                    }
                }
            }

            return lead;
        }
    }
}