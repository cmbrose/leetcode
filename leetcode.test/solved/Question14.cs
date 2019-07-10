using NUnit.Framework;

namespace leetcode.test
{
    public class Question14
    {
        [Test]
        public void TestExample()
        {
            Assert.AreEqual("fl", leetcode.Question14.Solve(new[] {"flower","flow","flight"}));
            Assert.AreEqual("", leetcode.Question14.Solve(new[] {"dog","racecar","car"}));
        }

        [Test]
        public void TestSingleWord()
        {
            Assert.AreEqual("flower", leetcode.Question14.Solve(new[] {"flower"}));
        }

        [Test]
        public void TestEmptyWord()
        {
            Assert.AreEqual("", leetcode.Question14.Solve(new[] {""}));
            Assert.AreEqual("", leetcode.Question14.Solve(new[] {"flower", ""}));
        }

        [Test]
        public void TestDuplicateWord()
        {
            Assert.AreEqual("flower", leetcode.Question14.Solve(new[] {"flower", "flower"}));
            Assert.AreEqual("flower", leetcode.Question14.Solve(new[] {"flower", "flower", "flowers"}));
        }
    }
}