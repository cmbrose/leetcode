using NUnit.Framework;
using leetcode.datastructures;

namespace leetcode.test
{
    public class Question236
    {
        private static void RunTest(int?[] tree, int p, int q, int t)
        {
            var root = TreeNode.TreeFromArray(tree);
            var act = leetcode.Question236.Solve(root, new TreeNode(p), new TreeNode(q));
            Assert.IsNotNull(act);
            Assert.AreEqual(t, act.val);
        }

        [TestCase]
        public void TestExample()
        {
            RunTest(new int?[] { 3,5,1,6,2,0,8,null,null,7,4 }, 5, 1, 3);
            RunTest(new int?[] { 3,5,1,6,2,0,8,null,null,7,4 }, 5, 4, 5);
        }

        [TestCase]
        public void TestSameNode()
        {
            RunTest(new int?[] { 3,5,1,6,2,0,8,null,null,7,4 }, 5, 5, 5);
            RunTest(new int?[] { 3,5,1,6,2,0,8,null,null,7,4 }, 3, 3, 3);
            RunTest(new int?[] { 3,5,1,6,2,0,8,null,null,7,4 }, 4, 4, 4);
        }

        [TestCase]
        public void TestUnidirectionalTree()
        {
            RunTest(new int?[] { 3,5,null,6,2,null, null,null,null,7,4 }, 6, 4, 5);
            RunTest(new int?[] { 3,null,1,null,null,0,8,null,null,null,null }, 0, 1, 1);
        }
    }
}