using NUnit.Framework;
using Problems;

namespace Tests
{
    public class Tests
    {
        private  Program _problems;

        [SetUp]
        public void Setup()
        {
        _problems = new Program();
        }

        [Test]
        public void Test1()
        {
            var test1= _problems.Prefix("hello"); 
            Assert.That(test1, Is.EqualTo("5,1:hello"));
            var test2 = _problems.Prefix("");
            Assert.That(test2, Is.EqualTo("0,0:"));
            var test3 = _problems.Prefix("what ... did you say??");
            Assert.That(test3, Is.EqualTo("22,5:what ... did you say??"));
        }
    }
}