using NUnit.Framework;

namespace leetcode.test
{
    public class Question1090
    {
        [Test]
        public void TestExample()
        {
            Assert.AreEqual(9, leetcode.Question1090.Solve(new[] { 5, 4, 3, 2, 1, }, new[] { 1, 1, 2, 2, 3, }, 3, 1));

            Assert.AreEqual(12, leetcode.Question1090.Solve(new[] { 5, 4, 3, 2, 1, }, new[] { 1, 3, 3, 3, 2, }, 3, 2));

            Assert.AreEqual(16, leetcode.Question1090.Solve(new[] { 9, 8, 8, 7, 6, }, new[] { 0, 0, 0, 1, 1, }, 3, 1));

            Assert.AreEqual(24, leetcode.Question1090.Solve(new[] { 9, 8, 8, 7, 6, }, new[] { 0, 0, 0, 1, 1, }, 3, 2));
        }

        [Test]
        public void TestNotEnoughItems()
        {
            Assert.AreEqual(5, leetcode.Question1090.Solve(new[] { 5, }, new[] { 1, }, 3, 1));

            Assert.AreEqual(9, leetcode.Question1090.Solve(new[] { 5, 4, }, new[] { 1, 2, }, 3, 1));

            Assert.AreEqual(8, leetcode.Question1090.Solve(new[] { 5, 4, 3, }, new[] { 0, 0, 1, }, 3, 1));
        }

        [Test]
        public void TestAllOneLabel()
        {
            Assert.AreEqual(5, leetcode.Question1090.Solve(new[] { 5, }, new[] { 1, }, 1, 1));

            Assert.AreEqual(5, leetcode.Question1090.Solve(new[] { 5, 4, }, new[] { 1, 1, }, 2, 1));

            Assert.AreEqual(9, leetcode.Question1090.Solve(new[] { 5, 4, }, new[] { 1, 1, }, 2, 2));
        }
    }
}