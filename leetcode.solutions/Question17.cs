using System.Linq;
using System.Collections.Generic;

namespace leetcode
{
    public static class Question17
    {
        public static IList<string> Solve(string digits)
        {
            if (string.IsNullOrEmpty(digits))
            {
                return new List<string>();
            }

            return SolveRec(digits.ToCharArray(), 0).Select(arr => new string(arr)).ToList();
        }

        private static readonly Dictionary<char, char[]> DigitToLetters = new Dictionary<char, char[]>
        {
            { '2', new[] { 'a', 'b', 'c' }},
            { '3', new[] { 'd', 'e', 'f' }},
            { '4', new[] { 'g', 'h', 'i' }},
            { '5', new[] { 'j', 'k', 'l' }},
            { '6', new[] { 'm', 'n', 'o' }},
            { '7', new[] { 'p', 'q', 'r', 's' }},
            { '8', new[] { 't', 'u', 'v' }},
            { '9', new[] { 'w', 'x', 'y', 'z' }},
        };

        private static IEnumerable<char[]> SolveRec(char[] digits, int startIdx)
        {
            char digit = digits[startIdx];
            char[] charsForDigit = DigitToLetters[digit];

            if (startIdx + 1 >= digits.Length)
            {
                foreach (char c in charsForDigit)
                {
                    char[] arr = new char[digits.Length];
                    arr[startIdx] = c;
                    yield return arr;
                }
            }
            else
            {
                IEnumerable<char[]> subSolves = SolveRec(digits, startIdx + 1);
                
                foreach (var c in charsForDigit)
                {
                    foreach (var sub in subSolves)
                    {
                        sub[startIdx] = c;
                        yield return sub;
                    }
                }
            }
        }
    }
}