using NUnit.Framework;

namespace Tests
{
    public class Question1
    {
        private static void RunTestCase(int[] nums, int target, int[] expectedOutput)
        {
            var actualOutput = leetcode.Question1.Solve(nums, target);

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [Test]
        public void TestExample()
        {
            RunTestCase(new[] {2, 7, 11, 15}, 9, new[] {0, 1});
        }

        [Test]
        public void TestAllNegative()
        {
            RunTestCase(new[] {-2, -7, -11, -15}, -9, new[] {0, 1});
        }

        [Test]
        public void TestPositiveAndNegative()
        {
            RunTestCase(new[] {-2, 7, -11, 15}, -4, new[] {1, 2});
            RunTestCase(new[] {-2, 7, -11, 15}, 13, new[] {0, 3});
        }

        [Test]
        public void TestZero()
        {
            RunTestCase(new[] {1, 8, 0, 3, 2}, 2, new[] {2, 4});
            RunTestCase(new[] {1, 8, 0, 3, 2}, 8, new[] {1, 2});
        }

        [Test]
        public void TestDuplicateItems()
        {
            RunTestCase(new[] {2, 2, 7, 11, 15}, 4, new[] {0, 1});
            RunTestCase(new[] {2, 2, 7, 11, 15}, 18, new[] {2, 3});
        }

        [Test]
        public void TestDescendingOrder()
        {
            RunTestCase(new[] {15, 11, 7, 2}, 9, new[] {2, 3});
        }
    }
}