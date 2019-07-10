namespace leetcode
{
    public static class Question2
    {
        public class ListNode 
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }
 
        public static ListNode Solve(ListNode l1, ListNode l2) {
            var cur1 = l1;
            var cur2 = l2;

            var dummyHead = new ListNode(-1);
            
            var res = dummyHead;
            var hasCarryOver = false;
            
            while (cur1 != null && cur2 != null)
            {
                var sum = cur1.val + cur2.val + (hasCarryOver ? 1 : 0);
                hasCarryOver = sum >= 10;

                res.next = new ListNode(hasCarryOver ? sum - 10 : sum);
                res = res.next;

                cur1 = cur1.next;
                cur2 = cur2.next;
            }

            var drain = cur1 ?? cur2;

            while (drain != null)
            {
                var sum = drain.val + (hasCarryOver ? 1 : 0);
                hasCarryOver = sum >= 10;

                res.next = new ListNode(hasCarryOver ? sum - 10 : sum);
                res = res.next;

                drain = drain.next;
            }

            if (hasCarryOver)
            {
                res.next = new ListNode(1);
            }

            return dummyHead.next;
        }
    }
}