using NUnit.Framework;

namespace Tests
{
    public class Question791
    {
        private static void RunTestCase(string S, string T, string expected)
        {
            var actual = leetcode.Question791.Solve(S, T);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestExample()
        {
            RunTestCase("cba", "abcd", "cbad");
        }

        [Test]
        public void TestNoChange()
        {
            RunTestCase("abcd", "abcd", "abcd");
            RunTestCase("ac", "abcd", "acbd");
        }

        [Test]
        public void TestReverse()
        {
            RunTestCase("dcba", "abcd", "dcba");
        }

        [Test]
        public void TestEdgeCases()
        {
            RunTestCase("", "abcd", "abcd");
            RunTestCase("abcd", "", "");
        }

        [Test]
        public void TestNormal()
        {
            RunTestCase("cba", "abdc", "cbad");
            RunTestCase("bca", "abdc", "bcad");

            RunTestCase("kqep", "pekeq", "kqeep");
        }        
    }
}