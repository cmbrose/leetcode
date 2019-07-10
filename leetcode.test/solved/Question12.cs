using NUnit.Framework;

namespace leetcode.test
{
    public class Question12
    {
        [Test]
        public void TestExamples()
        {
            Assert.AreEqual("III", leetcode.Question12.Solve(3));
            Assert.AreEqual("IV", leetcode.Question12.Solve(4));
            Assert.AreEqual("IX", leetcode.Question12.Solve(9));
            Assert.AreEqual("LVIII", leetcode.Question12.Solve(58));
            Assert.AreEqual("MCMXCIV", leetcode.Question12.Solve(1994));
        }     

        [Test]
        public void TestZero()
        {
            Assert.AreEqual("", leetcode.Question12.Solve(0));
        }   

        [Test]
        public void TestExact()
        {
            Assert.AreEqual("I", leetcode.Question12.Solve(1));
            
            Assert.AreEqual("V", leetcode.Question12.Solve(5));
            Assert.AreEqual("X", leetcode.Question12.Solve(10));
            
            Assert.AreEqual("L", leetcode.Question12.Solve(50));
            Assert.AreEqual("C", leetcode.Question12.Solve(100));

            Assert.AreEqual("D", leetcode.Question12.Solve(500));
            Assert.AreEqual("M", leetcode.Question12.Solve(1000));
        }  

        [Test]
        public void TestMinusOne()
        {           
            Assert.AreEqual("IV", leetcode.Question12.Solve(4));
            Assert.AreEqual("IX", leetcode.Question12.Solve(9));
            
            Assert.AreEqual("XL", leetcode.Question12.Solve(40));
            Assert.AreEqual("XC", leetcode.Question12.Solve(90));

            Assert.AreEqual("CD", leetcode.Question12.Solve(400));
            Assert.AreEqual("CM", leetcode.Question12.Solve(900));
        }  
    }
}