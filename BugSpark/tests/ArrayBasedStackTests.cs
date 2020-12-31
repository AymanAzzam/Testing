using System;
using System.Collections;
using NUnit.Framework;

namespace BugSpark
{
    [TestFixture]
    public class ArrayBasedStackTests
    {
        // Branch Coverage
        [Test]
        public void EmptyStackInit()
        {
            ArrayBasedStack<int> stack = new ArrayBasedStack<int> ();
            Assert.AreEqual(0, stack.Count);
            stack.Push(5);
            Assert.AreEqual(5, stack.Peek());
        }
        
        [Test]
        public void FilledStackInit()
        {
            ArrayBasedStack<int> stack = new ArrayBasedStack<int> (new [] {1, 2, 3});
            Assert.AreEqual(3, stack.Count);
            stack.Clear();
            Assert.AreEqual(0, stack.Count);
        }

        [Test]
        public void DoubleSizeStack()
        {
            ArrayBasedStack<int> stack = new ArrayBasedStack<int> (20);
            // Push more than default capacity and Resize
            for (int i = 0; i < 20; i++)
            {
                stack.Push(i);
            }
            Assert.AreEqual(21, stack.Count);
            stack.Pop();
            Assert.AreEqual(20, stack.Count);
            Assert.IsTrue(stack.Contains(20));
        }
        
        // BCC
        [Test]
        public void BCC_1()
        {
            ArrayBasedStack<int> stack = new ArrayBasedStack<int> (new [] {10, 10, 20});
            stack.Push(20);
            Assert.AreEqual(4, stack.Count);
            Assert.AreEqual(20, stack.Peek());
            stack.Pop();
            Assert.AreEqual(3, stack.Count);
            Assert.AreEqual(20, stack.Peek());
        }

        [Test]
        public void BCC_4()
        {
            ArrayBasedStack<int> stack = new ArrayBasedStack<int> (new [] {10, 20});
            stack.Push(30);
            Assert.AreEqual(3, stack.Count);
            Assert.AreEqual(30, stack.Peek());
            stack.Pop();
            Assert.AreEqual(2, stack.Count);
        }
        
        [Test]
        public void BCC_5()
        {
            ArrayBasedStack<int> stack = new ArrayBasedStack<int> (new [] {10, 10});
            stack.Push(-5);
            Assert.AreEqual(3, stack.Count);
            Assert.AreEqual(-5, stack.Peek());
            stack.Pop();
            Assert.AreEqual(2, stack.Count);
        }
        
        [Test]
        public void BCC_6()
        {
            ArrayBasedStack<int> stack = new ArrayBasedStack<int> (new [] {10, 10});
            stack.Push(0);
            Assert.AreEqual(3, stack.Count);
            Assert.AreEqual(0, stack.Peek());
            stack.Pop();
            Assert.IsFalse(stack.Contains(0));
        }
        
        [Test]
        public void BCC_7()
        {

            ArrayBasedStack<int> stack = new ArrayBasedStack<int> (10);
            stack.Push(10);
            Assert.AreEqual(2, stack.Count);
            stack.Pop();
            stack.Pop();
            Assert.AreEqual(0, stack.Count);
            try
            {
                stack.Pop();
                Assert.Fail("Stack didn't return exception on Pop() although the stack is empty");
            }
            catch (InvalidOperationException e)
            {
                Assert.AreEqual(e.Message, "There are no items in the stack.");
            }
            Assert.Throws<InvalidOperationException>(delegate { stack.Peek(); });
        }
        
        [Test]
        public void BCC_8()
        {
            ArrayBasedStack<int> stack = new ArrayBasedStack<int> (10);
            stack.Push(10);
            Assert.AreEqual(2, stack.Count);
            stack.Pop();
            Assert.AreEqual(10, stack.Peek());
            stack.Pop();
            Assert.AreEqual(0, stack.Count);
        }
    }
}