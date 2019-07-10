using System.Collections.Generic;
using leetcode.datastructures;

namespace leetcode
{
    public static class Question102
    {
        // Recursive
        public static IList<IList<int>> Solve(TreeNode root)
        {
            var res = new List<IList<int>>();

            Recurse(res, root, 0);

            return res;
        }

        private static void Recurse(List<IList<int>> res, TreeNode root, int depth)
        {
            if (root == null)
            {
                return;
            }

            if (depth >= res.Count)
            {
                res.Add(new List<int>());
            }

            res[depth].Add(root.val);

            if (root.left != null)
            {
                Recurse(res, root.left, depth + 1);
            }

            if (root.right != null)
            {
                Recurse(res, root.right, depth + 1);
            }
        }

        // No recursion, with 2 queues
        // public static IList<IList<int>> Solve(TreeNode root)
        // {
        //     var res = new List<IList<int>>();

        //     if (root == null)
        //     {
        //         return res;
        //     }

        //     var q1 = new Queue<TreeNode>();
        //     var q2 = new Queue<TreeNode>();

        //     q1.Enqueue(root);

        //     var curList = new List<int>();

        //     do
        //     {
        //         var node = q1.Dequeue();

        //         curList.Add(node.val);

        //         if (node.left != null)
        //         {
        //             q2.Enqueue(node.left);
        //         }

        //         if (node.right != null)
        //         {
        //             q2.Enqueue(node.right);
        //         }

        //         if (q1.Count == 0)
        //         {
        //             var tmp = q2;
        //             q2 = q1;
        //             q1 = tmp;

        //             res.Add(curList);
        //             curList = new List<int>();
        //         }

        //     } while (q1.Count > 0);

        //     return res;
        // }
    }
}