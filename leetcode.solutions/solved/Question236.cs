using leetcode.datastructures;

namespace leetcode
{
    public static class Question236
    {
        public static TreeNode Solve(TreeNode root, TreeNode p, TreeNode q)
        {
            return SearchRec(root, p, q, out bool _, out bool __);
        }

        private static TreeNode SearchRec(TreeNode root, TreeNode p, TreeNode q, out bool hasp, out bool hasq)
        {
            hasp = hasq = false;

            if (root.val == p.val)
            {
                hasp = true;
            }

            if (root.val == q.val)
            {
                hasq = true;
            }

            if (root.left != null)
            {
                bool lp, lq;
                TreeNode test = SearchRec(root.left, p, q, out lp, out lq);

                if (test != null)
                {
                    return test;
                }
                else if (lp)
                {
                    hasp = true;
                }
                else if (lq)
                {
                    hasq = true;
                }
            }

            if (root.right != null)
            {
                bool lp, lq;
                TreeNode test = SearchRec(root.right, p, q, out lp, out lq);

                if (test != null)
                {
                    return test;
                }
                else if (lp)
                {
                    hasp = true;
                }
                else if (lq)
                {
                    hasq = true;
                }
            }

            if (hasq && hasp)
            {
                return root;
            }

            return null;
        }
    }
}