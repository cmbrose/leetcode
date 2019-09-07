using NUnit.Framework;

namespace Tests
{
    public class Question50
    {
        [Test]
        public void TestExamples()
        {
            Assert.AreEqual(1024, leetcode.Question50.Solve(2, 10));
            Assert.AreEqual(9.261, leetcode.Question50.Solve(2.1, 3), 0.00001);
            Assert.AreEqual(0.25, leetcode.Question50.Solve(2, -2));
        }

        [Test]
        public void TestEdgeCases()
        {
            Assert.AreEqual(1, leetcode.Question50.Solve(2, 0));
            Assert.AreEqual(2, leetcode.Question50.Solve(2, 1));
            Assert.AreEqual(0.5, leetcode.Question50.Solve(2, -1));

            Assert.AreEqual(0, leetcode.Question50.Solve(0, 100));
            Assert.AreEqual(0, leetcode.Question50.Solve(0, -1));
            Assert.AreEqual(1, leetcode.Question50.Solve(1, 100));
        }

        [Test]
        public void TestHugePow()
        {
            Assert.AreEqual(1, leetcode.Question50.Solve(-1, -2147483648));
        }
    }
}