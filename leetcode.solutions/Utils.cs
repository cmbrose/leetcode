using System.Collections.Generic;

namespace leetcode
{
    public static class Utils
    {
        public static void Print<T>(IEnumerable<T> items)
        {
            System.Console.Write("[");

            foreach (var item in items)
            {
                System.Console.Write(item.ToString() + ", ");
            }

            System.Console.WriteLine("]");
        }
    }
}