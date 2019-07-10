namespace leetcode
{
    public static class Question20
    {
        public static bool Solve(string s) 
        {
            var stack = new System.Collections.Generic.Stack<char>(s.Length / 2);

            foreach (var c in s)
            {
                //System.Console.WriteLine($"c = {c}, IsOPen = {IsOpen(c)}");
                if (IsOpen(c))
                {
                    stack.Push(c);
                }
                else
                {
                    if (stack.Count == 0)
                    {
                        //System.Console.WriteLine($"too many closes");
                        return false;
                    }

                    var open = stack.Pop();

                    if (open != OpenFor(c))
                    {
                        //System.Console.WriteLine($"open = {open}, close = {c}");
                        return false;
                    }
                }
            }

            //System.Console.WriteLine($"length = {stack.Count}");
            return stack.Count == 0;
        }

        public static bool IsOpen(char c)
        {
            return c == '(' || c == '[' || c == '{';
        }

        public static char OpenFor(char c)
        {
            return c == ')' ? '('
                : c == ']' ? '['
                : '{';
        }
    }
}