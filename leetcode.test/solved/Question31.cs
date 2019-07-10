using NUnit.Framework;

namespace leetcode.test
{
    public class Question31
    {
        private static void RunTest(int[] testCase, int[] expected)
        {
            leetcode.Question31.Solve(testCase);

            System.Console.WriteLine(string.Join(", ", testCase));

            for (int i = 0; i < expected.Length; ++i)
            {
                Assert.AreEqual(expected[i], testCase[i], "Differed at index " + i);
            }
        }

        [Test]
        public void TestExamples()
        {
            RunTest(new[] { 1, 2, 3 }, new[] { 1, 3, 2 });
            RunTest(new[] { 3, 2, 1 }, new[] { 1, 2, 3 });
            RunTest(new[] { 1, 1, 5 }, new[] { 1, 5, 1 });

            RunTest(new[] { 1, 3, 2 }, new[] { 2, 1, 3 });
            RunTest(new[] { 5, 1, 1 }, new[] { 1, 1, 5 });
        }

        [Test]
        public void TestEdgeCases()
        {
            RunTest(new int[] { }, new int[] { });
            RunTest(new int[] { 1 }, new int[] { 1 });
        }

        [Test]
        public void Test2Numbers()
        {
            RunTest(new int[] { 1, 2 }, new int[] { 2, 1 });
            RunTest(new int[] { 2, 1 }, new int[] { 1, 2 });
        }

        [Test]
        public void TestNormalCases()
        {
            RunTest(new int[] { 3, 4, 2 }, new int[] { 4, 2, 3 });
            RunTest(new int[] { 3, 4, 2, 1 }, new int[] { 4, 1, 2, 3 });

            RunTest(new int[] { 1, 2, 3, 4 }, new int[] { 1, 2, 4, 3 });
            RunTest(new int[] { 1, 3, 4, 2 }, new int[] { 1, 4, 2, 3 });

            RunTest(new int[] { 1, 1, 2, 1, 1 }, new int[] { 1, 2, 1, 1, 1 });

            RunTest(new int[] { }, new int[] { });
        }
    }
}