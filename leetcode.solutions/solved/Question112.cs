using leetcode.datastructures;

namespace leetcode.solutions
{
    public static class Question112
    {
        public static bool Solve(TreeNode root, int sum)
        {
            return HasPathSum(root, sum);
        }

        public static bool HasPathSum(TreeNode root, int sum)
        {
            if (root == null)
            {
                return false;
            }

            if (root.left == null && root.right == null)
            {
                return root.val == sum;
            }
            
            // This would speed things up if input is only positive
            // if (root.val > sum)
            // {
            //     return false;
            // }

            return Solve(root.left, sum - root.val) || Solve(root.right, sum - root.val);
        }
    }
}