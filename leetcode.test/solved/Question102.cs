using System.Collections.Generic;
using NUnit.Framework;
using leetcode.datastructures;

namespace leetcode.test
{
    public class Question102
    {
        private static void RunTest(int?[] testCase, int[][] expected)
        {
            var actual = leetcode.Question102.Solve(TreeNode.TreeFromArray(testCase));

            Assert.AreEqual(expected.Length, actual.Count);

            for (int i = 0; i < expected.Length; ++i)
            {
                Assert.AreEqual(expected[i].Length, actual[i].Count);

                for (int j = 0; j < expected[i].Length; ++j)
                {
                    Assert.AreEqual(expected[i][j], actual[i][j]);
                }
            }
        }

        [Test]
        public void TestExample()
        {
            RunTest(new int?[] { 3, 9, 20, null, null, 15, 7 }, new int[][]
            {
                new[] { 3 },
                new[] { 9, 20 },
                new[] { 15, 7 },
            });
        }

        [Test]
        public void TestEmpty()
        {
            RunTest(new int?[] { }, new int[][] { });
        }

        [Test]
        public void TestRootOnly()
        {
            RunTest(new int?[] { 3, }, new int[][]
            {
                new[] { 3 },
            });
        }

        [Test]
        public void TestSingleNodePerLevel()
        {
            RunTest(new int?[] { 3, 9, null, 20, null, null, null }, new int[][]
            {
                new[] { 3 },
                new[] { 9, },
                new[] { 20, },
            });
        }

        [Test]
        public void TestFullTree()
        {
            RunTest(new int?[] { 3, 9, 20, 17, 42, 15, 7 }, new int[][]
            {
                new[] { 3 },
                new[] { 9, 20 },
                new[] { 17, 42, 15, 7 },
            });
        }

        [Test]
        public void TestSingleNodeOnTwoSides()
        {
            RunTest(new int?[] { 3, 9, 20, 15, null, null, 7 }, new int[][]
            {
                new[] { 3 },
                new[] { 9, 20 },
                new[] { 15, 7 },
            });
        }
    }
}