using leetcode.datastructures;

namespace leetcode
{
    public static class Question61
    {
        public static ListNode Solve(ListNode head, int k)
        {
            if (k == 0 || head == null)
            {
                return head;
            }

            ListNode fast = head, slow = head;

            int cnt = 0;
            while (cnt < k)
            {
                fast = fast.next;
                ++cnt;

                // Optimization - we have the length of the list here so we can use modulo to avoid useless looping
                if (fast == null)
                {
                    fast = head;
                    
                    k %= cnt;
                    cnt = 0;
                }
            }

            // k is a multiple of the length of the list -> no rotation
            if (fast == head)
            {
                return head;
            }

            while (fast.next != null)
            {
                slow = slow.next;
                fast = fast.next;
            }

            // slow now points to the item before the new head, fast points to the tail

            ListNode prev = slow;
            slow = slow.next ?? head;
            prev.next = null;

            fast.next = head;

            return slow;
        }
    }
}