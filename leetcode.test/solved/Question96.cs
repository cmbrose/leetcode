using NUnit.Framework;

namespace leetcode.test
{
    public class Question96
    {
        [Test]
        public void TestExample()
        {
            Assert.AreEqual(5, leetcode.Question96.Solve(3));
        }   

        [Test]
        public void TestEndCases()
        {
            Assert.AreEqual(1, leetcode.Question96.Solve(0));
            Assert.AreEqual(1, leetcode.Question96.Solve(1));
        }      

        [Test]
        public void TestEven()
        {
            Assert.AreEqual(2, leetcode.Question96.Solve(2));
            Assert.AreEqual(14, leetcode.Question96.Solve(4));
        }
    }
}