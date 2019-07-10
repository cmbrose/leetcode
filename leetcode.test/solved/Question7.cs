using NUnit.Framework;

namespace Tests
{
    public class Question7
    {       

        [Test]
        public void TestExample()
        {
            Assert.AreEqual(leetcode.Question7.Solve(123), 321);
            Assert.AreEqual(leetcode.Question7.Solve(-123), -321);
            Assert.AreEqual(leetcode.Question7.Solve(120), 21);
        }

        [Test]
        public void TestZero()
        {
            Assert.AreEqual(leetcode.Question7.Solve(0), 0);
        }

        [Test]
        public void TestSingleDigit()
        {
            Assert.AreEqual(leetcode.Question7.Solve(1), 1);
            Assert.AreEqual(leetcode.Question7.Solve(5), 5);
            Assert.AreEqual(leetcode.Question7.Solve(9), 9);
        }

        [Test]
        public void TestPalandrome()
        {
            Assert.AreEqual(leetcode.Question7.Solve(121), 121);
            Assert.AreEqual(leetcode.Question7.Solve(111), 111);
            Assert.AreEqual(leetcode.Question7.Solve(12321), 12321);
        }

        [Test]
        public void TestOverflow()
        {
            Assert.AreEqual(leetcode.Question7.Solve(2147483647), 0);
            Assert.AreEqual(leetcode.Question7.Solve(-2147483648), 0);

            Assert.AreEqual(leetcode.Question7.Solve(1534236469), 0);
            Assert.AreEqual(leetcode.Question7.Solve(-1534236469), 0);
        }

        [Test]
        public void TestLargeButOk()
        {
            Assert.AreEqual(leetcode.Question7.Solve(2147483641), 1463847412);
            Assert.AreEqual(leetcode.Question7.Solve(-2147483641), -1463847412);

            Assert.AreEqual(leetcode.Question7.Solve(1463847412), 2147483641);
            Assert.AreEqual(leetcode.Question7.Solve(-1463847412), -2147483641);
        }
    }
}