using NUnit.Framework;
using leetcode.datastructures;

namespace leetcode.test
{
    public static class Utils
    {
        public static void AssertLinkedListEqual(int[] expected, ListNode actual)
        {
            if (expected == null || expected.Length == 0)
            {
                Assert.IsNull(actual);
            }

            int i = 0;
            for (; i < expected.Length; ++i)
            {
                Assert.IsNotNull(actual, $"List terminated too early.  Length was {i}, but expected {expected.Length}.");

                Assert.AreEqual(expected[i], actual.val);

                actual = actual.next;
            }

            int extraCnt = 0;
            while (actual != null && extraCnt++ < 100)
            {
                ++i;
                actual = actual.next;
            }

            Assert.IsNull(actual, $"List too long.  Length was {i}, but expected {expected.Length}.");
        }
    }
}