using System;
using NUnit.Framework;

namespace BugSpark
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void StackInit()
        {
            var stack = new ArrayBasedStack<int> ();
            stack.Push(3);
            Assert.AreEqual(stack.Peek(), 3);
        }
    }
}