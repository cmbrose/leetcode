using NUnit.Framework;

namespace leetcode.test
{
    public class Question13
    {
        [Test]
        public void TestExample()
        {
            Assert.AreEqual(3, leetcode.Question13.Solve("III"));
            Assert.AreEqual(4, leetcode.Question13.Solve("IV"));
            Assert.AreEqual(9, leetcode.Question13.Solve("IX"));
            Assert.AreEqual(58, leetcode.Question13.Solve("LVIII"));
            Assert.AreEqual(1994, leetcode.Question13.Solve("MCMXCIV"));
        }

        [Test]
        public void TestEmpty()
        {
            Assert.AreEqual(0, leetcode.Question13.Solve(""));
        }

        [Test]
        public void TestInvalid()
        {
            Assert.Throws<System.Exception>(() => leetcode.Question13.Solve("A"));
        }

        [Test]
        public void TestAllSubtractions()
        {
            Assert.AreEqual(4, leetcode.Question13.Solve("IV"));
            Assert.AreEqual(9, leetcode.Question13.Solve("IX"));

            Assert.AreEqual(40, leetcode.Question13.Solve("XL"));
            Assert.AreEqual(90, leetcode.Question13.Solve("XC"));

            Assert.AreEqual(400, leetcode.Question13.Solve("CD"));
            Assert.AreEqual(900, leetcode.Question13.Solve("CM"));
        }
    }
}