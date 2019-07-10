using NUnit.Framework;

namespace leetcode.test.solved
{
    public class Question5
    {
        [Test]
        public void TestExample()
        {
            Assert.AreEqual("bab", leetcode.Question5.Solve("babad"));
            Assert.AreEqual("bb", leetcode.Question5.Solve("cbbd"));
            Assert.AreEqual("aaabaaa", leetcode.Question5.Solve("aaaabaaa"));
        }

        [Test]
        public void TestEmpty()
        {
            Assert.AreEqual("", leetcode.Question5.Solve(""));
        }
        
        [Test]
        public void TestFullPalindrome()
        {
            Assert.AreEqual("a", leetcode.Question5.Solve("a"));
            Assert.AreEqual("aa", leetcode.Question5.Solve("aa"));
            Assert.AreEqual("aaa", leetcode.Question5.Solve("aaa"));
            Assert.AreEqual("aba", leetcode.Question5.Solve("aba"));
            Assert.AreEqual("abba", leetcode.Question5.Solve("abba"));
        }

        [Test]
        public void TestPalindromeAtStart()
        {
            Assert.AreEqual("a", leetcode.Question5.Solve("ac"));
            Assert.AreEqual("aa", leetcode.Question5.Solve("aac"));
            Assert.AreEqual("aaa", leetcode.Question5.Solve("aaac"));
            Assert.AreEqual("aba", leetcode.Question5.Solve("abac"));
            Assert.AreEqual("abba", leetcode.Question5.Solve("abbac"));
        }

        [Test]
        public void TestPalindromeAtEnd()
        {
            Assert.AreEqual("aa", leetcode.Question5.Solve("caa"));
            Assert.AreEqual("aaa", leetcode.Question5.Solve("caaa"));
            Assert.AreEqual("aba", leetcode.Question5.Solve("caba"));
            Assert.AreEqual("abba", leetcode.Question5.Solve("cabba"));
        }

        [Test]
        public void TestPalindromeInCenter()
        {
            Assert.AreEqual("aa", leetcode.Question5.Solve("caad"));
            Assert.AreEqual("aaa", leetcode.Question5.Solve("caaad"));
            Assert.AreEqual("aba", leetcode.Question5.Solve("cabad"));
            Assert.AreEqual("abba", leetcode.Question5.Solve("cabbad"));
        }

        [Test]
        public void TestMultiplePalindromes()
        {
            Assert.AreEqual("aaa", leetcode.Question5.Solve("aaabb"));
            Assert.AreEqual("aba", leetcode.Question5.Solve("abacbb"));
            Assert.AreEqual("bacab", leetcode.Question5.Solve("abbacaba"));
        }
    }
}