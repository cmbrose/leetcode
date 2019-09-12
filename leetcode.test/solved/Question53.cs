using NUnit.Framework;

namespace leetcode.test
{
    public class Question53
    {
        [Test]
        public void TestExample()
        {
            Assert.AreEqual(6, leetcode.Question53.Solve(new[] { -2,1,-3,4,-1,2,1,-5,4 }));
        }

        [Test]
        public void TestEdgeCases()
        {
            Assert.AreEqual(0, leetcode.Question53.Solve(new int[] { }));
            Assert.AreEqual(0, leetcode.Question53.Solve(new[] { 0 }));
            Assert.AreEqual(1, leetcode.Question53.Solve(new[] { 1 }));
            Assert.AreEqual(-1, leetcode.Question53.Solve(new[] { -1 }));
        }

        [Test]
        public void TestAllPositive()
        {
            Assert.AreEqual(3, leetcode.Question53.Solve(new[] { 0, 1, 2 }));
            Assert.AreEqual(6, leetcode.Question53.Solve(new[] { 1, 2, 3 }));
            Assert.AreEqual(3, leetcode.Question53.Solve(new[] { 1, 1, 0, 1 }));
        }

        [Test]
        public void TestAllNegative()
        {
            Assert.AreEqual(0, leetcode.Question53.Solve(new[] { -1, 0 }));
            Assert.AreEqual(0, leetcode.Question53.Solve(new[] { -1, 0, -2 }));
            Assert.AreEqual(0, leetcode.Question53.Solve(new[] { 0, -2 }));
            Assert.AreEqual(-1, leetcode.Question53.Solve(new[] { -1, -2, -3 }));
        }
    }
}