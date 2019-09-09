using NUnit.Framework;

namespace Tests
{
    public class Question926
    {        
        [Test]
        public void TestExample()
        {
            Assert.AreEqual(1, leetcode.Question926.Solve("00110"));
            Assert.AreEqual(2, leetcode.Question926.Solve("010110"));
            Assert.AreEqual(2, leetcode.Question926.Solve("00011000"));
        }

        [Test]
        public void TestEdgeCases()
        {
            Assert.AreEqual(0, leetcode.Question926.Solve(""));

            Assert.AreEqual(0, leetcode.Question926.Solve("0"));
            Assert.AreEqual(0, leetcode.Question926.Solve("00"));
            Assert.AreEqual(0, leetcode.Question926.Solve("00000"));

            Assert.AreEqual(0, leetcode.Question926.Solve("1"));
            Assert.AreEqual(0, leetcode.Question926.Solve("11"));
            Assert.AreEqual(0, leetcode.Question926.Solve("11111"));
        }

        [Test]
        public void TestAlreadyMonotone()
        {
            Assert.AreEqual(0, leetcode.Question926.Solve("01"));
            Assert.AreEqual(0, leetcode.Question926.Solve("001"));
            Assert.AreEqual(0, leetcode.Question926.Solve("000001"));

            Assert.AreEqual(0, leetcode.Question926.Solve("01"));
            Assert.AreEqual(0, leetcode.Question926.Solve("011"));
            Assert.AreEqual(0, leetcode.Question926.Solve("011111"));

            Assert.AreEqual(0, leetcode.Question926.Solve("0011"));
            Assert.AreEqual(0, leetcode.Question926.Solve("00011"));
            Assert.AreEqual(0, leetcode.Question926.Solve("00111"));
            Assert.AreEqual(0, leetcode.Question926.Solve("0000011111"));
        }

        [Test]
        public void TestNormal()
        {
            Assert.AreEqual(5, leetcode.Question926.Solve("10011111110010111011"));
            Assert.AreEqual(23, leetcode.Question926.Solve("01111010011111110100000101110100011000000010011010"));
        }
    }
}