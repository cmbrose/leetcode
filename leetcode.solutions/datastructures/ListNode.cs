namespace leetcode
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }

        public static ListNode ListFromArray(int[] arr)
        {
            if (arr == null)
            {
                return null;
            }

            ListNode dummy = new ListNode(-1);
            ListNode cur = dummy;

            foreach (var item in arr)
            {
                cur.next = new ListNode(item);
                cur = cur.next;
            }

            return dummy.next;
        }
    }
}