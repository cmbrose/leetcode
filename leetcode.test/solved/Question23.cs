using System.Linq;
using NUnit.Framework;

namespace leetcode.test
{
    public class Question23
    {
        private static void PrintList(leetcode.Question23.ListNode head)
        {
            TestContext.Out.Write("[");

            while (head != null)
            {
                TestContext.Out.Write(head.val + ", ");
                head = head.next;
            }

            TestContext.Out.Write("]");
        }

        private static leetcode.Question23.ListNode ToLinkedList(int[] num)
        {
            if (num == null || num.Length == 0) {
                return null;
            }

            leetcode.Question23.ListNode head = new leetcode.Question23.ListNode(num[0]);
            leetcode.Question23.ListNode curr = head;

            for (int i = 1; i < num.Length; ++i) 
            {
                curr.next = new leetcode.Question23.ListNode(num[i]);
                curr = curr.next;
            }

            return head;
        } 

        private static void RunTestCase(int[][] lists, int[] expectedOutput)
        {
            var nodes = lists.Select(ToLinkedList).ToArray();

            foreach (var node in nodes)
            {
                PrintList(node);
            }

            leetcode.Question23.ListNode expectedHead = ToLinkedList(expectedOutput);
            
            leetcode.Question23.ListNode actualHead = leetcode.Question23.Solve(nodes);

            TestContext.Out.Write("Expected: ");
            PrintList(expectedHead);
            TestContext.Out.WriteLine();
            TestContext.Out.Write("Actual: ");
            PrintList(actualHead);

            var eCurr = expectedHead;
            var aCurr = actualHead;

            while (eCurr != null && aCurr != null)
            {
                Assert.AreEqual(eCurr.val, aCurr.val);

                eCurr = eCurr.next;
                aCurr = aCurr.next;
            }

            if (eCurr == null)
            {
                Assert.IsNull(aCurr, "Returned list is too long");
            }
            else
            {
                Assert.Fail("Returned list is too short");
            }
        }

        [Test]
        public void TestExample()
        {
            RunTestCase
            (
                new[]
                {
                    new[] { 1, 4, 5 },
                    new[] { 1, 3, 4 },
                    new[] { 2, 6 },
                },
                new[] { 1, 1, 2, 3, 4, 4, 5, 6 }
            );
        }
    }
}