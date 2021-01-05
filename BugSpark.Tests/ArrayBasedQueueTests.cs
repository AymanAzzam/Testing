using System;
using NUnit.Framework;
using BugSpark.Source;

namespace BugSpark.Tests
{
    [TestFixture]
    public class ArrayBasedQueueTests
    {

        [Test]
        public void Enqueue_Branch_Test_1()
        {
            ArrayBasedQueue<int> queue = new ArrayBasedQueue<int>(1);
            queue.Enqueue(1);
            Assert.AreEqual(queue.Peek(), 1);
        }

        [Test]
        public void Enqueue_Branch_Test_2()
        {
            ArrayBasedQueue<int> queue = new ArrayBasedQueue<int>(2);
            queue.Enqueue(1);
            Assert.AreEqual(queue.Peek(), 1);
        }
        
        [Test]
        public void Enqueue_Branch_Test_3()
        {
            ArrayBasedQueue<int> queue = new ArrayBasedQueue<int>(1);
            queue.Enqueue(1);
            try
            {
                queue.Enqueue(2);
                Assert.Fail("Enqueue didn't return exception although the queue is full");
            }
            catch (InvalidOperationException e)
            {
                Assert.AreEqual(e.Message, "The queue has reached its capacity.");
            }
        }
        
        [Test]
        public void Dequeue_Branch_Test_1()
        {
            ArrayBasedQueue<int> queue = new ArrayBasedQueue<int>(10);
            try
            {
                queue.Dequeue();
                Assert.Fail("Dequeue didn't return exception although the queue is empty");
            }
            catch (InvalidOperationException e)
            {
                Assert.AreEqual(e.Message, "There are no items in the queue.");
            }
        }
        
        [Test]
        public void Dequeue_Branch_Test_2()
        {
            ArrayBasedQueue<int> queue = new ArrayBasedQueue<int>(10);
            queue.Enqueue(23);
            Assert.AreEqual(queue.Dequeue(), 23);
        }
        
        [Test]
        public void Dequeue_Branch_Test_3()
        {
            ArrayBasedQueue<int> queue = new ArrayBasedQueue<int>(1);
            queue.Enqueue(23);
            Assert.AreEqual(queue.Dequeue(), 23);
        }
        
        [Test]
        public void Peek_Branch_Test_1()
        {
            ArrayBasedQueue<int> queue = new ArrayBasedQueue<int>(1);
            try
            {
                queue.Peek();
                Assert.Fail("Peek didn't return exception although the queue is empty");
            }
            catch (InvalidOperationException e)
            {
                Assert.AreEqual(e.Message, "There are no items in the queue.");
            }
        }

        [Test]
        public void Clear_Node_Test_1()
        {
            ArrayBasedQueue<int> queue = new ArrayBasedQueue<int>(10);
            queue.Enqueue(1);
            queue.Enqueue(2);
            
            queue.Clear();
            Assert.AreEqual(queue.IsEmpty(), true);

        }

    }
}