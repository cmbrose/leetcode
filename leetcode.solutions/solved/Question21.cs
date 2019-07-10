namespace leetcode
{
    public static class Question21
    {
        public static ListNode Solve(ListNode l1, ListNode l2)
        {
            if (l1 == null && l2 == null)
            {
                return null;
            }

            if (l1 == null)
            {
                return l2;
            }

            if (l2 == null)
            {
                return l1;
            }

            ListNode head;

            if (l1.val < l2.val)
            {
                head = l1;
                l1 = l1.next;
            }
            else
            {
                head = l2;
                l2 = l2.next;
            }

            ListNode curr = head;

            while (l1 != null && l2 != null)
            {
                if (l1.val < l2.val)
                {
                    curr.next = l1;

                    do
                    {
                        l1 = l1.next;
                        curr = curr.next;
                    }
                    while (l1 != null && l1.val <= l2.val);
                }
                else
                {
                    curr.next = l2;

                    do
                    {
                        l2 = l2.next;
                        curr = curr.next;
                    }
                    while (l2 != null && l1.val >= l2.val);                
                }
            }

            curr.next = l1 == null ? l2 : l1;

            return head;
        }

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }
    }
}