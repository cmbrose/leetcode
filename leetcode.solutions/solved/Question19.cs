using System.Collections.Generic;
using leetcode.datastructures;

namespace leetcode
{
    public static class Question19
    {
        // Single Pass, two pointers - O(n), O(1)
        public static ListNode Solve(ListNode head, int n) 
        {            
            if (head == null)
            {
                return null;
            }

            ListNode hare = head, tort = head;

            while (n > 0)
            {
                hare = hare.next;
                --n;
            }

            // Remove the head
            if (hare == null)
            {
                return head.next;
            }

            while (hare.next != null)
            {
                hare = hare.next;
                tort = tort.next;
            }

            tort.next = tort.next.next;

            return head;
        }

        // Double pass, counting nodes - O(n), O(1)
        // public static ListNode Solve(ListNode head, int n) 
        // {            
        //     if (head == null)
        //     {
        //         return null;
        //     }

        //     int cnt = 1;
            
        //     ListNode cur = head.next;
        //     while (cur != null)
        //     {
        //         cur = cur.next;
        //         ++cnt;
        //     }

        //     var prevIdx = cnt - n - 1;

        //     if (prevIdx == -1)
        //     {
        //         return head.next;
        //     }

        //     int idx = 0;
        //     cur = head;

        //     while (idx != prevIdx)
        //     {
        //         cur = cur.next;
        //         ++idx;
        //     }

        //     cur.next = cur.next.next;

        //     return head;
        // }

        // Single pass, using a Queue - O(n), O(n)
        // public static ListNode Solve(ListNode head, int n) 
        // {            
        //     if (head == null)
        //     {
        //         return null;
        //     }

        //     var queue = new Queue<ListNode>(n + 1);

        //     var cur = head;

        //     while (cur != null)
        //     {                
        //         if (queue.Count > n)
        //         {
        //             queue.Dequeue();
        //         }

        //         queue.Enqueue(cur);

        //         cur = cur.next;
        //     }

        //     // This case only happens when removing the head
        //     if (queue.Count == n)
        //     {
        //         return head.next;
        //     }

        //     var prev = queue.Dequeue();
            
        //     prev.next = prev.next.next;

        //     return head;
        // }
    }
}