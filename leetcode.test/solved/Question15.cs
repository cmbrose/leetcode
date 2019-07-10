using System;
using System.Linq;
using System.Collections.Generic;
using NUnit.Framework;

namespace leetcode.test
{
    public class Question15
    {
        private static void RunTest(int[] nums, int[][] expected)
        {
            var actual = leetcode.Question15.Solve(nums);

            PrintResult(actual);
            Assert.AreEqual(expected.Length, actual.Count);

            foreach (var eTup in expected)
            {
                Assert.IsTrue(actual.Any(aTup => aTup.Select(a => eTup.Contains(a)).All(b => b)));
            }
        }

        private static void PrintResult(IList<IList<int>> actual)
        {
            foreach (var tuple in actual)
            {
                Console.WriteLine("[" + string.Join(", ", tuple) + "]");
            }
        }

        [Test]
        public void TestExample()
        {
            RunTest(new[] { -1, 0, 1, 2, -1, -4, }, new[] 
            {
                new[] { -1, 0, 1 },
                new[] { -1, -1, 2 },
            });

            RunTest(new[] { 0, 0, 0, 0 }, new[] 
            {
                new[] { 0, 0, 0 },
            });

            RunTest(new[] { -2, 0, 1, 1, 2 }, new[] 
            {
                new[] { -2, 0, 2 },
                new[] { -2, 1, 1 },
            });

            RunTest(new[] { 4, 0, 2, 3, -1 }, new int[][] { });
        }
    }
}