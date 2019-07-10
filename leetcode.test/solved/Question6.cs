using NUnit.Framework;

namespace leetcode.test
{
    public class Question6
    {
        [Test]
        public void TestExample()
        {
            Assert.AreEqual("PAHNAPLSIIGYIR", leetcode.Question6.Solve("PAYPALISHIRING", 3));
            Assert.AreEqual("PINALSIGYAHRPI", leetcode.Question6.Solve("PAYPALISHIRING", 4));

            Assert.AreEqual("A", leetcode.Question6.Solve("A", 2));

            Assert.AreEqual("ACB", leetcode.Question6.Solve("ABC", 2));
            Assert.AreEqual("ABC", leetcode.Question6.Solve("ABC", 3));
        }
    }
}