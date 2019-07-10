using NUnit.Framework;

namespace leetcode.test
{
    public class Question21
    {
        private static void PrintList(leetcode.Question21.ListNode head)
        {
            TestContext.Out.Write("[");

            while (head != null)
            {
                TestContext.Out.Write(head.val + ", ");
                head = head.next;
            }

            TestContext.Out.Write("]");
        }

        private static leetcode.Question21.ListNode ToLinkedList(int[] num)
        {
            if (num == null || num.Length == 0) {
                return null;
            }

            leetcode.Question21.ListNode head = new leetcode.Question21.ListNode(num[0]);
            leetcode.Question21.ListNode curr = head;

            for (int i = 1; i < num.Length; ++i) 
            {
                curr.next = new leetcode.Question21.ListNode(num[i]);
                curr = curr.next;
            }

            return head;
        } 

        private static void RunTestCase(int[] num1, int[] num2, int[] expectedOutput)
        {
            leetcode.Question21.ListNode list1Head = ToLinkedList(num1);
            leetcode.Question21.ListNode list2Head = ToLinkedList(num2);
            leetcode.Question21.ListNode expectedHead = ToLinkedList(expectedOutput);
            
            leetcode.Question21.ListNode actualHead = leetcode.Question21.Solve(list1Head, list2Head);

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
            RunTestCase(new[] { 1, 2, 4 }, new[] { 1, 3, 4 }, new[] { 1, 1, 2, 3, 4, 4 });
        }

        [Test]
        public void TestEmptyLists()
        {
            RunTestCase(new int[] { }, new int[] { }, new int[] { });
            RunTestCase(new int[] { 1, 2, 3 }, new int[] { }, new int[] { 1, 2, 3 });
            RunTestCase(new int[] { }, new int[] { 1, 2, 3 }, new int[] { 1, 2, 3 });
        }

        [Test]
        public void TestSingleItemLists()
        {
            RunTestCase(new int[] { 1 }, new int[] { 2 }, new int[] { 1, 2 });
            RunTestCase(new int[] { 2 }, new int[] { 1 }, new int[] { 1, 2 });

            RunTestCase(new int[] { 2 }, new int[] { 1, 3 }, new int[] { 1, 2, 3 });
            RunTestCase(new int[] { 1, 3 }, new int[] { 2 }, new int[] { 1, 2, 3 });
        }

        [Test]
        public void TestListAllLessThanOther()
        {
            RunTestCase(new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[] { 1, 2, 3, 4, 5, 6 });
            RunTestCase(new int[] { 4, 5, 6 }, new int[] { 1, 2, 3 }, new int[] { 1, 2, 3, 4, 5, 6 });
        }

        [Test]
        public void TestListEqual()
        {
            RunTestCase(new int[] { 1, 2, 3 }, new int[] { 1, 2, 3 }, new int[] { 1, 1, 2, 2, 3, 3 });
            RunTestCase(new int[] { 1, 2, 3 }, new int[] { 1, 2, 3 }, new int[] { 1, 1, 2, 2, 3, 3 });
        }

        [Test]
        public void TestNormalCases()
        {
            RunTestCase(new int[] { 1, 3, 5 }, new int[] { 2, 4, 6 }, new int[] { 1, 2, 3, 4, 5, 6 });
            RunTestCase(new int[] { 2, 4, 6 }, new int[] { 1, 3, 5 }, new int[] { 1, 2, 3, 4, 5, 6 });

            RunTestCase(new int[] { 1, 3, 4 }, new int[] { 2, 5, 6 }, new int[] { 1, 2, 3, 4, 5, 6 });
            RunTestCase(new int[] { 1, 1, 2 }, new int[] { 2, 2, 3 }, new int[] { 1, 1, 2, 2, 2, 3 });

            RunTestCase(new int[] { 1, 5, 6 }, new int[] { 2, 3, 4 }, new int[] { 1, 2, 3, 4, 5, 6 });
        }
    }
}