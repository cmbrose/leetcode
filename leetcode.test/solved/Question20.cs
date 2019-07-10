using NUnit.Framework;

namespace leetcode.test
{
    public class Question20
    {
        [Test]
        public void TestExample()
        {
            Assert.IsTrue(leetcode.Question20.Solve("()"));
            Assert.IsTrue(leetcode.Question20.Solve("()[]{}"));

            Assert.IsFalse(leetcode.Question20.Solve("(]"));
            Assert.IsFalse(leetcode.Question20.Solve("([)]"));

            Assert.IsTrue(leetcode.Question20.Solve("{[]}"));
        }

        [Test]
        public void TestEmpty()
        {
            Assert.IsTrue(leetcode.Question20.Solve(""));
        }

        [Test]
        public void TestSameTypeNested()
        {
            Assert.IsTrue(leetcode.Question20.Solve("(())"));
            Assert.IsTrue(leetcode.Question20.Solve("((()))"));
            
            Assert.IsTrue(leetcode.Question20.Solve("(()[])"));
            Assert.IsTrue(leetcode.Question20.Solve("(([]))"));
            Assert.IsTrue(leetcode.Question20.Solve("([([])])"));
        }

        [Test]
        public void TestNotClosed()
        {
            Assert.IsFalse(leetcode.Question20.Solve("("));
            Assert.IsFalse(leetcode.Question20.Solve("(()"));
            
            Assert.IsFalse(leetcode.Question20.Solve("([]"));
            Assert.IsFalse(leetcode.Question20.Solve("(()[]"));
        }

        [Test]
        public void TestTooManyCloses()
        {
            Assert.IsFalse(leetcode.Question20.Solve(")"));
            Assert.IsFalse(leetcode.Question20.Solve("())"));
            
            Assert.IsFalse(leetcode.Question20.Solve("[])"));
            Assert.IsFalse(leetcode.Question20.Solve("[]())"));
            Assert.IsFalse(leetcode.Question20.Solve("([]))"));
        }
    }
}