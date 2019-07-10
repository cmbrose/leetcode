namespace leetcode
{
    public static class Question6
    {
        public static string Solve(string s, int numRows)
        {
            if (numRows == 1 || s.Length < numRows)
            {
                return s;
            }

            int length = (numRows - 1) * 2;

            System.Text.StringBuilder bldr = new System.Text.StringBuilder(s.Length);

            for (int row = 0; row < numRows; ++row)
            {
                int rowLength = (numRows - row - 1) * 2;
                if (rowLength == 0)
                {
                    rowLength = length;
                }

                int skip = rowLength;
                
                int scan = row;

                do
                {
                    bldr.Append(s[scan]);
                    scan += skip;

                    skip = length - skip;
                    if (skip == 0)
                    {
                        skip = rowLength;
                    }
                } while (scan < s.Length);
            }

            return bldr.ToString();
        }
    }
}