using NUnit.Framework;

namespace leetcode.test
{
    public class Question3
    {
        [Test]
        public void TestExample()
        {
            Assert.AreEqual(3, leetcode.Question3.Solve("abcabcbb"));
            Assert.AreEqual(1, leetcode.Question3.Solve("bbbbb"));
            Assert.AreEqual(3, leetcode.Question3.Solve("pwwkew"));

            Assert.AreEqual(5, leetcode.Question3.Solve("tmmzuxt"));
            Assert.AreEqual(7, leetcode.Question3.Solve("wsslpluuwekuaxt"));
        }

        [Test]
        public void TestEmpty()
        {
            Assert.AreEqual(0, leetcode.Question3.Solve(""));
        }

        [Test]
        public void TestDistinct()
        {
            Assert.AreEqual(1, leetcode.Question3.Solve("a"));
            Assert.AreEqual(2, leetcode.Question3.Solve("ab"));
            Assert.AreEqual(3, leetcode.Question3.Solve("abc"));
        }

        [Test]
        public void TestRunFromStart()
        {
            Assert.AreEqual(4, leetcode.Question3.Solve("abcda"));
            Assert.AreEqual(4, leetcode.Question3.Solve("abcdb"));
            Assert.AreEqual(4, leetcode.Question3.Solve("abcdd"));
        }

        [Test]
        public void TestRunInMiddle()
        {
            Assert.AreEqual(4, leetcode.Question3.Solve("aabcdd"));
            Assert.AreEqual(4, leetcode.Question3.Solve("babcdc"));
            Assert.AreEqual(4, leetcode.Question3.Solve("aabcdc"));
        }

        [Test]
        public void TestRunAtEnd()
        {
            Assert.AreEqual(4, leetcode.Question3.Solve("aabcd"));
            Assert.AreEqual(4, leetcode.Question3.Solve("babcd"));
            Assert.AreEqual(4, leetcode.Question3.Solve("cabcd"));
            Assert.AreEqual(5, leetcode.Question3.Solve("tmtmzuxt"));
        }
    }
}