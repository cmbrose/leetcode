using NUnit.Framework;
using leetcode.datastructures;

namespace leetcode.test
{
    public class Question61
    {
        private static void RunTest(int[] inputList, int k, int[] expected)
        {
            var actual = leetcode.Question61.Solve(ListNode.ListFromArray(inputList), k);

            Utils.AssertLinkedListEqual(expected, actual);
        }

        [Test]
        public void TestExamples()
        {
            RunTest(new[] { 1, 2, 3, 4, 5 }, 2, new[] { 4, 5, 1, 2, 3 });
            RunTest(new[] { 0, 1, 2 }, 4, new[] { 2, 0, 1 });
        }

        [Test]
        public void TestEdgeCases()
        {
            // Empty list
            RunTest(new int[] { }, 2, new int[] { });

            // Single node list
            RunTest(new[] { 1 }, 1, new[] { 1 });
            RunTest(new[] { 1 }, 4, new[] { 1 });

            // No rotation
            RunTest(new[] { 1 }, 0, new[] { 1 });
            RunTest(new[] { 1, 2, 3 }, 0, new[] { 1, 2, 3 });

            // K = len(list)
            RunTest(new[] { 1, 2 }, 2, new[] { 1, 2 });
            RunTest(new[] { 1, 2, 3 }, 3, new[] { 1, 2, 3 });
            RunTest(new[] { 1, 2, 3 }, 6, new[] { 1, 2, 3 }); // Modulo
        }

        [Test]
        public void TestBasic()
        {
            RunTest(new[] { 1, 2, 3 }, 1, new[] { 3, 1, 2 });

            RunTest(new[] { 1, 2, 3, 4, 5 }, 1, new[] { 5, 1, 2, 3, 4 });
            RunTest(new[] { 1, 2, 3, 4, 5 }, 2, new[] { 4, 5, 1, 2, 3 });
            RunTest(new[] { 1, 2, 3, 4, 5 }, 3, new[] { 3, 4, 5, 1, 2 });            
            RunTest(new[] { 1, 2, 3, 4, 5 }, 4, new[] { 2, 3, 4, 5, 1 });
        }
    }
}