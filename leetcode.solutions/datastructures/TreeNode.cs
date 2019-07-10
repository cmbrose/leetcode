namespace leetcode.datastructures
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }

        public static TreeNode TreeFromArray(int?[] arr, int rootIdx = 0)
        {
            if (arr == null || arr.Length <= rootIdx || !arr[rootIdx].HasValue)
            {
                return null;
            }

            TreeNode root = new TreeNode(arr[rootIdx].Value);

            root.left = TreeFromArray(arr, rootIdx * 2 + 1);
            root.right = TreeFromArray(arr, rootIdx * 2 + 2);

            return root;
        }
    }
}