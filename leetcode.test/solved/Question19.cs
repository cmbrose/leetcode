using NUnit.Framework;
using leetcode.datastructures;

namespace leetcode.test
{
    public class Question19
    {
        private static void RunTest(int[] list, int n, int[] expected)
        {
            var inputList = BuildList(list);
            
            var actual = leetcode.Question19.Solve(inputList, n);

            var cur = actual;
            if (expected == null || expected.Length == 0)
            {
                Assert.IsNull(cur);
            }
            else
            {
                foreach (var item in expected)
                {
                    Assert.IsNotNull(cur, "List shorter than expected");
                    Assert.AreEqual(item, cur.val);
                    cur = cur.next;
                }

                Assert.IsNull(cur, "List longer than expected");
            }
        }

        private static ListNode BuildList(int[] list)
        {
            var dummy = new ListNode(-1);
            var cur = dummy;
            foreach (var item in list)
            {
                cur.next = new ListNode(item);
                cur = cur.next;
            }

            return dummy.next;
        }

        [Test]
        public void TestExample()
        {
            RunTest(new[] { 1, 2, 3, 4, 5 }, 2, new[] { 1, 2, 3, 5 });
        }

        [Test]
        public void TestEmpty()
        {
            RunTest(new int[] { }, 0, new int[] { });
        }

        [Test]
        public void TestSingleNode()
        {
            RunTest(new[] { 1, }, 1, new int[] { });
        }

        [Test]
        public void TestRemoveHead()
        {
            RunTest(new[] { 1, 2 }, 2, new[] { 2 });
            RunTest(new[] { 1, 2, 3 }, 3, new[] { 2, 3, });
            RunTest(new[] { 1, 2, 3, 4 }, 4, new[] { 2, 3, 4 });
        }

        [Test]
        public void TestRemoveTail()
        {
            RunTest(new[] { 1, 2 }, 1, new[] { 1 });
            RunTest(new[] { 1, 2, 3 }, 1, new[] { 1, 2 });
            RunTest(new[] { 1, 2, 3, 4 }, 1, new[] { 1, 2, 3 });
        }
    }
}