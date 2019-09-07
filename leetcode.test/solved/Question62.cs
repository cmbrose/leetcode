using NUnit.Framework;

namespace leetcode.test
{
    public class Question62
    {
        [Test]
        public void TestExamples()
        {
            Assert.AreEqual(3, leetcode.Question62.Solve(3, 2));
            Assert.AreEqual(28, leetcode.Question62.Solve(7, 3));
            Assert.AreEqual(28, leetcode.Question62.Solve(3, 7));
        }

        [Test]
        public void TestSingleCell()
        {
            Assert.AreEqual(1, leetcode.Question62.Solve(1, 1));
        }

        [Test]
        public void Test1Dimension()
        {
            Assert.AreEqual(1, leetcode.Question62.Solve(1, 100));
            Assert.AreEqual(1, leetcode.Question62.Solve(100, 1));
        }
    }
}