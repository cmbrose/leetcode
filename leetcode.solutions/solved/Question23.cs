using System.Linq;
using leetcode.datastructures;

namespace leetcode
{
    public static class Question23
    {
        // Divide and conquer
        public static ListNode Solve(ListNode[] lists)
        {
            return SolveRec(lists, 0, lists.Length);
        }

        private static ListNode SolveRec(ListNode[] lists, int start, int end)
        {
            if (start == end)
            {
                return null;
            }
            else if (start + 1 == end)
            {
                return lists[start];
            }
            else if (start + 2 == end)
            {
                return Merge(lists[start], lists[start + 1]);
            }
            else
            {
                int half = (end - start) / 2;
                ListNode left = SolveRec(lists, start, start + half);
                ListNode right = SolveRec(lists, start + half, end);

                return Merge(left, right);
            }
        }

        // Copy from Question21
        public static ListNode Merge(ListNode l1, ListNode l2)
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

        // Using a Heap
        // public static ListNode Solve(ListNode[] lists)
        // {
        //     var heap = new MinHeap<ListNode>(new System.Collections.Generic.List<ListNode>(lists).Where(l => l != null).ToList(), (l1, l2) => l1.val - l2.val);

        //     if (heap.Count == 0)
        //     {
        //         return null;
        //     }

        //     ListNode head = heap.Pop();
        //     ListNode curr = head;

        //     while (heap.Count > 0)
        //     {
        //         ListNode next = heap.Pop();

        //         while (curr.next != null && curr.next.val <= next.val)
        //         {
        //             curr = curr.next;
        //         }

        //         if (curr.next != null)
        //         {
        //             heap.Push(curr.next);
        //         }

        //         curr.next = next;
        //         curr = curr.next;
        //     }

        //     return head;
        // }

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }

        private static void PrintHeap(MinHeap<ListNode> heap)
        {
            for (int i = 0; i < heap.Count; ++i)
            {
                var node = heap._items[i];
                System.Console.WriteLine($"{i}: [ {node.val}->{node?.next?.val}->{node?.next?.next?.val} ]");
            }
        }
    }
}