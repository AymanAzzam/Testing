using System;
using NUnit.Framework;
using BugSpark.Source;

namespace BugSpark.Tests
{
    [TestFixture]
    public class ArrayBasedQueueTests
    {

        [Test, Author("Ayman Elakwah")]
        public void Enqueue_Branch_Test_1()
        {
            ArrayBasedQueue<int> queue = new ArrayBasedQueue<int>(1);
            queue.Enqueue(1);
            Assert.Multiple(() =>
            {
                Assert.AreEqual(queue.Peek(), 1);
                Assert.IsTrue(queue.IsFull());
                Assert.IsFalse(queue.IsEmpty());
            });
            
        }

        [Test, Author("Ayman Elakwah")]
        public void Enqueue_Branch_Test_2()
        {
            ArrayBasedQueue<int> queue = new ArrayBasedQueue<int>(2);
            queue.Enqueue(1);
            Assert.Multiple(() =>
            {
                Assert.AreEqual(queue.Peek(), 1);
                Assert.IsFalse(queue.IsFull());
                Assert.IsFalse(queue.IsEmpty());
            });
        }
        
        [Test, Author("Ayman Elakwah")]
        public void Enqueue_Branch_Test_3()
        {
            ArrayBasedQueue<int> queue = new ArrayBasedQueue<int>(1);
            queue.Enqueue(1);
            Assert.That(() => queue.Enqueue(1), 
                Throws.TypeOf<InvalidOperationException>()
                    .With.Message.EqualTo("The queue has reached its capacity."));
        }

        [Test, Author("Ayman Elakwah")]
        public void Dequeue_Branch_Test_1()
        {
            ArrayBasedQueue<int> queue = new ArrayBasedQueue<int>(10);
            Assert.That(() => queue.Dequeue(),
                Throws.TypeOf<InvalidOperationException>()
                    .With.Message.EqualTo("There are no items in the queue."));
        }
        
        [Test, Author("Ayman Elakwah")]
        public void Dequeue_Branch_Test_2()
        {
            ArrayBasedQueue<int> queue = new ArrayBasedQueue<int>(10);
            queue.Enqueue(23);
            Assert.AreEqual(queue.Dequeue(), 23);
        }
        
        [Test, Author("Ayman Elakwah")]
        public void Dequeue_Branch_Test_3()
        {
            ArrayBasedQueue<int> queue = new ArrayBasedQueue<int>(1);
            queue.Enqueue(23);
            Assert.AreEqual(queue.Dequeue(), 23);
        }
        
        [Test, Author("Ayman Elakwah")]
        public void Peek_Branch_Test_1()
        {
            ArrayBasedQueue<int> queue = new ArrayBasedQueue<int>(1);
            Assert.That(() => queue.Peek(),
                Throws.TypeOf<InvalidOperationException>()
                    .With.Message.EqualTo("There are no items in the queue."));
        }

        [Test, Author("Ayman Elakwah")]
        public void Clear_Branch_Test_1()
        {
            ArrayBasedQueue<int> queue = new ArrayBasedQueue<int>(10);
            queue.Enqueue(1);
            queue.Enqueue(2);
            
            queue.Clear();
            
            Assert.Multiple(() =>
            {
                Assert.IsTrue(queue.IsEmpty());
                Assert.IsFalse(queue.IsFull());
                Assert.That(() => queue.Dequeue(),
                    Throws.TypeOf<InvalidOperationException>()
                        .With.Message.EqualTo("There are no items in the queue."));
            });

        }

    }
}