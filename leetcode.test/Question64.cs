using NUnit.Framework;

namespace leetcode.test
{
    public class Question64
    {
        [Test]
        public void TestExamples()
        {
            Assert.AreEqual(7, leetcode.Question64.Solve(new int[][]
            {
                new int[] { 1, 3, 1 },
                new int[] { 1, 5, 1 },
                new int[] { 4, 2, 1 },
            }));
        }

        [Test]
        public void TestSingleCell()
        {
            Assert.AreEqual(1, leetcode.Question64.Solve(new int[][]
            {
                new int[] { 1 },
            }));
        }

        [Test]
        public void Test1Dimension()
        {
            Assert.AreEqual(3, leetcode.Question64.Solve(new int[][]
            {
                new int[] { 1, 1, 1 },
            }));

            Assert.AreEqual(3, leetcode.Question64.Solve(new int[][]
            {
                new int[] { 1 },
                new int[] { 1 },
                new int[] { 1 },
            }));
        }

        [Test]
        public void TestRectangular()
        {
            Assert.AreEqual(4, leetcode.Question64.Solve(new int[][]
            {
                new int[] { 1, 1, 1 },
                new int[] { 1, 2, 1 },
            }));

            Assert.AreEqual(4, leetcode.Question64.Solve(new int[][]
            {
                new int[] { 1, 1 },
                new int[] { 1, 2 },
                new int[] { 1, 1 },
            }));
        }
    }
}