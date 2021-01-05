using System;
using System.Collections;
using NUnit.Framework;
using BugSpark.Source;

namespace BugSpark.Tests
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
        public void BCC_5()
        {
            ArrayBasedStack<int> stack = new ArrayBasedStack<int> (4);
            Assert.AreEqual(0, stack.Count);
            Assert.Throws<InvalidOperationException>(delegate
            {
                stack.Pop();
            });
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
        public void BCC_8()
        {
            Assert.Throws<InvalidOperationException>(delegate
            {
                ArrayBasedStack<int> stack = new ArrayBasedStack<int>(-1);
            });
        }
        
        [Test]
        public void BCC_9()
        {
            Assert.Throws<InvalidOperationException>(delegate
            {
                ArrayBasedStack<int> stack = new ArrayBasedStack<int>(0);
            });
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
        
        // Edge Coverage
        [Test]
        public void EC_Constructor_1()
        {
            ArrayBasedStack<int> stack = new ArrayBasedStack<int> (4);
        }
        
        [Test]
        public void EC_Constructor_2()
        {
            Assert.Throws<InvalidOperationException>(delegate
            {
                ArrayBasedStack<int> stack = new ArrayBasedStack<int>(-1);
            });
        }
        
        [Test]
        public void EC_Capacity_1()
        {
            ArrayBasedStack<int> stack = new ArrayBasedStack<int> (1);
            Assert.AreEqual(1, stack.Capacity);
        }
        
        [Test]
        public void EC_Capacity_2()
        {
            ArrayBasedStack<int> stack = new ArrayBasedStack<int> (1);
            stack.Capacity = 10;
            Assert.AreEqual(10, stack.Capacity);
        }
        
        [Test]
        public void EC_Clear()
        {
            ArrayBasedStack<int> stack = new ArrayBasedStack<int> (1);
            stack.Push(1);
            Assert.AreEqual(1, stack.Count);
            stack.Clear();
            Assert.AreEqual(0, stack.Count);
        }
        
        [Test]
        public void EC_Peek_1()
        {
            ArrayBasedStack<int> stack = new ArrayBasedStack<int> (4);
            stack.Push(1);
            Assert.AreEqual(1, stack.Peek());
        }
        
        [Test]
        public void EC_Peek_2()
        {
            ArrayBasedStack<int> stack = new ArrayBasedStack<int>(1);
            Assert.Throws<InvalidOperationException>(delegate
            {
                stack.Peek();
            });
        }
        
        [Test]
        public void EC_Pop_1()
        {
            ArrayBasedStack<int> stack = new ArrayBasedStack<int> (4);
            stack.Push(1);
            stack.Push(2);
            Assert.AreEqual(2, stack.Count);
            stack.Pop();
            Assert.AreEqual(1, stack.Count);
        }
        
        [Test]
        public void EC_Pop_2()
        {
            ArrayBasedStack<int> stack = new ArrayBasedStack<int>(1);
            Assert.Throws<InvalidOperationException>(delegate
            {
                stack.Pop();
            });
        }
        
        [Test]
        public void EC_Push_1()
        {
            ArrayBasedStack<int> stack = new ArrayBasedStack<int> (4);
            stack.Push(1);
            stack.Push(2);
            Assert.AreEqual(2, stack.Count);
        }
        
        [Test]
        public void EC_Push_2()
        {
            ArrayBasedStack<int> stack = new ArrayBasedStack<int> (2);
            stack.Push(1);
            stack.Push(2);
            Assert.AreEqual(stack.Capacity, stack.Count);
            stack.Push(3);
            // Capacity is doubled to 8
            Assert.AreNotEqual(stack.Capacity, stack.Count);
        }
        
        [Test]
        public void EC_Contains()
        {
            ArrayBasedStack<int> stack = new ArrayBasedStack<int> (2);
            stack.Push(1);
            stack.Push(2);
            Assert.IsTrue(stack.Contains(1));
            Assert.IsFalse(stack.Contains(5));
        }
    }
}