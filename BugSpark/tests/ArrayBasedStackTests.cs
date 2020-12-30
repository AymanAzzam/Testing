using System;
using NUnit.Framework;

namespace BugSpark
{
    [TestFixture]
    public class ArrayBasedStackTests
    {
        [Test]
        public void EmptyStackInit()
        {
            ArrayBasedStack<int> stack = new ArrayBasedStack<int> ();
            Assert.AreEqual(0, stack.Count);
        }
        
        [Test]
        public void FilledStackInit()
        {
            ArrayBasedStack<int> stack = new ArrayBasedStack<int> (new [] {1, 2, 3});
            Assert.AreEqual(3, stack.Count);
        }

        [Test]
        public void OneItemStackInit_Peek()
        {
            ArrayBasedStack<int> stack = new ArrayBasedStack<int>(4);
            Assert.AreEqual(4, stack.Peek());
        }

        [Test]
        public void PushStack()
        {
            
        }
    }
}