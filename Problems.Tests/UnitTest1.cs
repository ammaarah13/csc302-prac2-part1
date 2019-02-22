using NUnit.Framework;
using Problems;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Program p = new Program();
            string result = p.Prefix("hello");
            Assert.AreEqual("5,1:hello", result);
            string result1 = p.Prefix("");
            Assert.AreEqual("0,0:", result1);
            string result2 = p.Prefix("what ... did you say?? ");
            Assert.AreEqual("23,5:what ... did you say?? ", result2);
        }
        
    }
}