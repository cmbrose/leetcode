using NUnit.Framework;

namespace leetcode.test
{
    public class Question9
    {
        [Test]
        public void TestExample()
        {
            Assert.IsTrue(leetcode.Question9.Solve(121));

            Assert.IsFalse(leetcode.Question9.Solve(-121));
            Assert.IsFalse(leetcode.Question9.Solve(10));
        }

        [Test]
        public void TestEndsInZero()
        {
            Assert.IsTrue(leetcode.Question9.Solve(0));
            
            Assert.IsFalse(leetcode.Question9.Solve(10));
            Assert.IsFalse(leetcode.Question9.Solve(100));
        }

        [Test]
        public void TestContainsZero()
        {
            Assert.IsTrue(leetcode.Question9.Solve(101));
            Assert.IsTrue(leetcode.Question9.Solve(1001));
            Assert.IsTrue(leetcode.Question9.Solve(10001));
            Assert.IsTrue(leetcode.Question9.Solve(100001));
        }

        [Test]
        public void TestSingleDigit()
        {
            Assert.IsTrue(leetcode.Question9.Solve(1));
            Assert.IsTrue(leetcode.Question9.Solve(5));
            Assert.IsTrue(leetcode.Question9.Solve(9));
        }

        [Test]
        public void TestEvenDigits()
        {
            Assert.IsTrue(leetcode.Question9.Solve(11));
            Assert.IsTrue(leetcode.Question9.Solve(1221));
            Assert.IsTrue(leetcode.Question9.Solve(112211));
            
            Assert.IsFalse(leetcode.Question9.Solve(1122));
            Assert.IsFalse(leetcode.Question9.Solve(112233));
        }

        [Test]
        public void TestOddDigits()
        {
            Assert.IsTrue(leetcode.Question9.Solve(121));
            Assert.IsTrue(leetcode.Question9.Solve(12321));
            Assert.IsTrue(leetcode.Question9.Solve(1123211));
            
            Assert.IsFalse(leetcode.Question9.Solve(11233));
            Assert.IsFalse(leetcode.Question9.Solve(11233));
        }
    }
}