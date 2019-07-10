using NUnit.Framework;

namespace leetcode.test
{
    public class Question8
    {
        [Test]
        public void TestExamples()
        {
            Assert.AreEqual(42, leetcode.Question8.Solve("42"));
            Assert.AreEqual(-42, leetcode.Question8.Solve("   -42"));
            Assert.AreEqual(4193, leetcode.Question8.Solve("4193 with words"));
            Assert.AreEqual(0, leetcode.Question8.Solve("words and 987"));
            //Assert.AreEqual(-2147483648, leetcode.Question8.Solve("-91283472332"));
        }

        [Test]
        public void TestWhiteSpace()
        {
            Assert.AreEqual(42, leetcode.Question8.Solve("  42"));
            Assert.AreEqual(42, leetcode.Question8.Solve("42   "));
            Assert.AreEqual(42, leetcode.Question8.Solve("  42  "));
        }

        [Test]
        public void TestEmpty()
        {
            Assert.AreEqual(0, leetcode.Question8.Solve(""));
            Assert.AreEqual(0, leetcode.Question8.Solve(" "));
            Assert.AreEqual(0, leetcode.Question8.Solve("  "));
        }

        [Test]
        public void TestNonDigits()
        {
            Assert.AreEqual(42, leetcode.Question8.Solve("42 and more"));
            Assert.AreEqual(42, leetcode.Question8.Solve("42 and another 42"));
            Assert.AreEqual(0, leetcode.Question8.Solve("stuff before the 42"));
        }

        [Test]
        public void TestSign()
        {
            Assert.AreEqual(0, leetcode.Question8.Solve("+"));
            Assert.AreEqual(42, leetcode.Question8.Solve("+42"));
            Assert.AreEqual(42, leetcode.Question8.Solve("   +42"));

            Assert.AreEqual(0, leetcode.Question8.Solve("-"));
            Assert.AreEqual(-42, leetcode.Question8.Solve("-42"));
            Assert.AreEqual(-42, leetcode.Question8.Solve("   -42"));

            Assert.AreEqual(0, leetcode.Question8.Solve("+-"));
            Assert.AreEqual(0, leetcode.Question8.Solve("-+"));

            Assert.AreEqual(0, leetcode.Question8.Solve("+word"));
            Assert.AreEqual(0, leetcode.Question8.Solve("-word"));
        }

        [Test]
        public void TestLargeNumbers()
        {
            Assert.AreEqual(int.MaxValue, leetcode.Question8.Solve(int.MaxValue.ToString()));
            Assert.AreEqual(int.MaxValue - 1, leetcode.Question8.Solve((int.MaxValue - 1).ToString()));
            Assert.AreEqual(int.MaxValue - 10, leetcode.Question8.Solve((int.MaxValue - 10).ToString()));
            Assert.AreEqual(int.MaxValue / 10, leetcode.Question8.Solve((int.MaxValue / 10).ToString()));
            Assert.AreEqual(int.MaxValue / 10 + 1, leetcode.Question8.Solve((int.MaxValue / 10 + 1).ToString()));
            Assert.AreEqual(int.MaxValue / 10 - 1, leetcode.Question8.Solve((int.MaxValue / 10 - 1).ToString()));
            Assert.AreEqual(int.MaxValue, leetcode.Question8.Solve(((long) int.MaxValue + 1).ToString()));
            Assert.AreEqual(int.MaxValue, leetcode.Question8.Solve(((long) int.MaxValue + 10000).ToString()));
            Assert.AreEqual(int.MaxValue, leetcode.Question8.Solve(int.MaxValue.ToString() + "0000000000000000"));

            Assert.AreEqual(-1 * int.MaxValue, leetcode.Question8.Solve((-1 * int.MaxValue).ToString()));

            Assert.AreEqual(int.MinValue, leetcode.Question8.Solve(int.MinValue.ToString()));
            Assert.AreEqual(int.MinValue + 1, leetcode.Question8.Solve((int.MinValue + 1).ToString()));
            Assert.AreEqual(int.MinValue + 10, leetcode.Question8.Solve((int.MinValue + 10).ToString()));
            Assert.AreEqual(int.MinValue / 10, leetcode.Question8.Solve((int.MinValue / 10).ToString()));
            Assert.AreEqual(int.MinValue / 10 + 1, leetcode.Question8.Solve((int.MinValue / 10 + 1).ToString()));
            Assert.AreEqual(int.MinValue / 10 - 1, leetcode.Question8.Solve((int.MinValue / 10 - 1).ToString()));
            Assert.AreEqual(int.MinValue, leetcode.Question8.Solve(((long) int.MinValue - 1).ToString()));
            Assert.AreEqual(int.MinValue, leetcode.Question8.Solve(((long) int.MinValue - 10000).ToString()));
            Assert.AreEqual(int.MinValue, leetcode.Question8.Solve(int.MinValue.ToString() + "0000000000000000"));
        }
    }
}