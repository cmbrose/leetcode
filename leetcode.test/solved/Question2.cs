using NUnit.Framework;

namespace Tests
{
    public class Question2
    {
        private static void PrintList(leetcode.Question2.ListNode head)
        {
            TestContext.Out.Write("[");

            while (head != null)
            {
                TestContext.Out.Write(head.val + ", ");
                head = head.next;
            }

            TestContext.Out.Write("]");
        }

        private static leetcode.Question2.ListNode ToLinkedList(int[] num)
        {
            if (num == null || num.Length == 0) {
                return null;
            }

            leetcode.Question2.ListNode head = new leetcode.Question2.ListNode(num[0]);
            leetcode.Question2.ListNode curr = head;

            for (int i = 1; i < num.Length; ++i) 
            {
                curr.next = new leetcode.Question2.ListNode(num[i]);
                curr = curr.next;
            }

            return head;
        }

        private static void RunTestCase(int[] num1, int[] num2, int[] expectedOutput)
        {
            leetcode.Question2.ListNode list1Head = ToLinkedList(num1);
            leetcode.Question2.ListNode list2Head = ToLinkedList(num2);
            leetcode.Question2.ListNode expectedHead = ToLinkedList(expectedOutput);
            
            leetcode.Question2.ListNode actualHead = leetcode.Question2.Solve(list1Head, list2Head);

            TestContext.Out.Write("Expected: ");
            PrintList(expectedHead);

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
            RunTestCase(new[] {2, 4, 3}, new[] {5, 6, 4}, new[] {7, 0, 8});
        }

        [Test]
        public void TestZero()
        {
            RunTestCase(new[] {0}, new[] {5, 6, 4}, new[] {5, 6, 4});
            RunTestCase(new[] {5, 6, 4}, new[] {0}, new[] {5, 6, 4});

            RunTestCase(new[] {0}, new[] {0}, new[] {0});

            RunTestCase(new[] {5, 6, 4}, new[] {0, 1}, new[] {5, 7, 4});
            RunTestCase(new[] {0, 1}, new[] {5, 6, 4}, new[] {5, 7, 4});
        }

        [Test]
        public void TestAddDigit()
        {
            RunTestCase(new[] {1}, new[] {9}, new[] {0, 1});
            RunTestCase(new[] {1}, new[] {9, 9}, new[] {0, 0, 1});

            RunTestCase(new[] {9}, new[] {9}, new[] {8, 1});
        }

        [Test]
        public void TestNulls()
        {
            RunTestCase(new[] {1}, null, new[] {1});
            RunTestCase(null, new[] {1}, new[] {1});

            RunTestCase(null, null, null);
        }

        [Test]
        public void TestDifferentLengths()
        {
            RunTestCase(new[] {1}, new[] {0, 1}, new[] {1, 1});
            RunTestCase(new[] {1}, new[] {0, 0, 1}, new[] {1, 0, 1});

            RunTestCase(new[] {0, 1}, new[] {1}, new[] {1, 1});
            RunTestCase(new[] {0, 0, 1}, new[] {1}, new[] {1, 0, 1});        
        }
    }
}