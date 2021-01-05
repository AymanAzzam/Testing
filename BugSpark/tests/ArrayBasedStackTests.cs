using System;
using System.Collections;
using NUnit.Framework;

namespace BugSpark
{
    [TestFixture]
    public class ArrayBasedStackTests
    {
        // BCC
        [Test]
        public void BCC_1()
        {
            ArrayBasedStack<int> stack = new ArrayBasedStack<int> (4);
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Assert.AreEqual(3, stack.Count);
            Assert.IsTrue(stack.Contains(2));
            Assert.AreNotEqual(stack.Count, stack.Capacity);
        }
        
        [Test]
        public void BCC_6()
        {
            ArrayBasedStack<int> stack = new ArrayBasedStack<int> (4);
            Assert.AreEqual(0, stack.Count);
            stack.Push(1);
            Assert.IsTrue(stack.Contains(1));
            Assert.AreNotEqual(stack.Count, stack.Capacity);
        }

        [Test]
        public void BCC_7()
        {
            ArrayBasedStack<int> stack = new ArrayBasedStack<int> (4);
            stack.Push(10);
            Assert.AreEqual(1, stack.Count);
            stack.Push(1);
            Assert.IsTrue(stack.Contains(10));
            Assert.AreNotEqual(stack.Count, stack.Capacity);
        }
        
        [Test]
        public void BCC_10()
        {
            ArrayBasedStack<int> stack = new ArrayBasedStack<int> (1);
            stack.Push(10);
            stack.Push(20);
            Assert.AreEqual(2, stack.Count);
            stack.Push(1);
            Assert.IsTrue(stack.Contains(10));
            Assert.AreNotEqual(stack.Count, stack.Capacity);
        }
        
        [Test]
        public void BCC_11()
        {
            ArrayBasedStack<int> stack = new ArrayBasedStack<int> (4);
            stack.Push(-1);
            stack.Push(-2);
            stack.Push(-3);
            Assert.AreEqual(3, stack.Count);
            Assert.IsTrue(stack.Contains(-2));
            Assert.AreNotEqual(stack.Count, stack.Capacity);
        }
        
        [Test]
        public void BCC_12()
        {
            ArrayBasedStack<int> stack = new ArrayBasedStack<int> (4);
            stack.Push(0);
            stack.Push(0);
            stack.Push(0);
            Assert.AreEqual(3, stack.Count);
            Assert.IsTrue(stack.Contains(0));
            Assert.AreNotEqual(stack.Count, stack.Capacity);
        }
        
        [Test]
        public void BCC_13()
        {
            ArrayBasedStack<int> stack = new ArrayBasedStack<int> (4);
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Assert.AreEqual(3, stack.Count);
            Assert.IsFalse(stack.Contains(-2));
            Assert.AreNotEqual(stack.Count, stack.Capacity);
        }
        
        [Test]
        public void BCC_14()
        {
            ArrayBasedStack<int> stack = new ArrayBasedStack<int> (4);
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            Assert.AreEqual(4, stack.Count);
            Assert.IsTrue(stack.Contains(2));
            Assert.AreEqual(stack.Count, stack.Capacity);
            stack.Push(5);
            Assert.AreNotEqual(stack.Count, stack.Capacity);
        }
    }
}