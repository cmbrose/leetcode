using NUnit.Framework;
using System.Linq;

namespace leetcode.test
{
    public class Question17
    {
        private static void RunTestCase(string digits, string[] expected)
        {
            expected = expected.OrderBy(x => x).ToArray();
            var actual = leetcode.Question17.Solve(digits).OrderBy(x => x).ToArray();

            Assert.AreEqual(expected.Length, actual.Length);
            for (int i = 0; i < expected.Length; ++i)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }

        [Test]
        public void TestExample()
        {
            RunTestCase("23", new[] {"ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf"});
        }

        [Test]
        public void TestEmpty()
        {
            RunTestCase("", new string[] { });
        }

        [Test]
        public void TestSingleDigit()
        {
            RunTestCase("2", new string[] { "a", "b", "c" });
            RunTestCase("7", new string[] {  "p", "q", "r", "s" });
        }
    }
}