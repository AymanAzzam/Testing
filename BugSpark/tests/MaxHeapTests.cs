using System;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;

/*
 * DONE: interface based Input-Domain-Modelling
 * TODO: Sorted extraction logic => functionality based Input-Domain-Modelling
 */

namespace BugSpark
{
    [TestFixture]
    public class BinaryMaxHeapTests
    {
        private BinaryMaxHeap<int> _binaryMaxHeap;
        [SetUp]
        public void SetUp()
        {
            _binaryMaxHeap = new BinaryMaxHeap<int>();
        }

        [TearDown]
        public void TearDown()
        {
            _binaryMaxHeap = null;
        }

        [Test]
        public void Constructor_Empty()
        {
            var binaryMaxHeap = new BinaryMaxHeap<int>();
            
            Assert.Zero(binaryMaxHeap.array.Capacity, "Capacity");
        }

        [Test]
        public void Constructor_Value()
        {
            var binaryMaxHeap = new BinaryMaxHeap<int>(1);
            
            Assert.AreEqual(1, binaryMaxHeap.array.Capacity, "Capacity");
        }

        [Test]
        public void Constructor_Zero()
        {
            Assert.DoesNotThrow(delegate
            {
                var binaryMaxHeap = new BinaryMaxHeap<int>(0);
            });
        }

        [Test]
        public void Constructor_CapacityOutOfBounds()
        {
            Assert.Throws<ArgumentOutOfRangeException>(delegate
            {
                new BinaryMaxHeap<int>(-1, Comparer<int>.Default);
            });
        }

        [Test]
        public void IsEmpty_True()
        {
            Assert.IsTrue(_binaryMaxHeap.IsEmpty);
        }

        [Test]
        public void IsEmpty_False()
        {
            _binaryMaxHeap.Add(5);
            Assert.IsFalse(_binaryMaxHeap.IsEmpty);
        }

        [Test]
        public void Add_Value()
        {
            Assert.Zero(_binaryMaxHeap.Count, "Count before");
            
            _binaryMaxHeap.Add(5);
            
            Assert.AreEqual(1, _binaryMaxHeap.Count, "Count after");
        }

        [Test]
        public void Add_ArrayFull()
        {
            var tempBinaryMaxHeap = new BinaryMaxHeap<int>(4);
            var list = new List<int>() {1, 4, 3, 5};
            tempBinaryMaxHeap.Heapify(list);
            Assert.AreEqual(4, tempBinaryMaxHeap.Count, "Count before");
            Assert.AreEqual(4, tempBinaryMaxHeap.array.Capacity, "Capacity before");
            var before = tempBinaryMaxHeap.array.Capacity;

            tempBinaryMaxHeap.Add(10);
            
            Assert.Greater(tempBinaryMaxHeap.Count, before, "Count after");
            Assert.Greater(tempBinaryMaxHeap.array.Capacity, before, "Capacity after");
        }

        [Test]
        public void Add_ZeroCapacity()
        {
            var tempBinaryMaxHeap = new BinaryMaxHeap<int>(0);
            Assert.IsTrue(tempBinaryMaxHeap.IsEmpty);
            Assert.Zero(tempBinaryMaxHeap.Count, "Count before");
            Assert.Zero(tempBinaryMaxHeap.array.Capacity, "Capacity before");

            tempBinaryMaxHeap.Add(10);
            
            Assert.IsFalse(tempBinaryMaxHeap.IsEmpty);
            Assert.NotZero(tempBinaryMaxHeap.Count, "Count after");
            Assert.NotZero(tempBinaryMaxHeap.array.Capacity, "Capacity after");
        }

        [Test]
        public void PeekMax_Empty()
        {
            Assert.Throws<InvalidOperationException>(delegate
            {
                _binaryMaxHeap.PeekMax();
            });
        }

        [Test]
        public void PeekMax_SingleValue()
        {
            _binaryMaxHeap.Add(5);
            
            Assert.AreEqual(5, _binaryMaxHeap.PeekMax(), "Peek Max Value");
        }

        [Test]
        public void PeekMax_MultipleValues()
        {
            _binaryMaxHeap.Add(-1);
            _binaryMaxHeap.Add(3);
            _binaryMaxHeap.Add(5);
            
            Assert.AreEqual(5, _binaryMaxHeap.PeekMax());
        }

        [Test]
        public void ReplaceMax_Empty()
        {
            Assert.Throws<InvalidOperationException>(delegate
            {
                _binaryMaxHeap.ReplaceMax(2);
            });
        }

        [Test]
        public void ReplaceMax_Available()
        {
            _binaryMaxHeap.Add(5);
            
            Assert.AreEqual(5, _binaryMaxHeap.PeekMax(), "Max before");
            
            _binaryMaxHeap.ReplaceMax(4);
            
            Assert.AreEqual(4, _binaryMaxHeap.PeekMax(), "Max After");
        }

        [Test]
        public void ReplaceMax_ChangeRoot()
        {
            _binaryMaxHeap.Add(5);
            _binaryMaxHeap.Add(9);
            
            Assert.AreEqual(9, _binaryMaxHeap.PeekMax(), "Max before");
            
            _binaryMaxHeap.ReplaceMax(4);
            
            Assert.AreEqual(5, _binaryMaxHeap.PeekMax(), "Max After");
        }

        [Test]
        public void RemoveMax_Empty()
        {
            Assert.Throws<InvalidOperationException>(delegate
            {
                _binaryMaxHeap.RemoveMax();
            });
        }

        [Test]
        public void RemoveMax_Available()
        {
            _binaryMaxHeap.Add(5);
            _binaryMaxHeap.Add(9);
            
            Assert.AreEqual(2, _binaryMaxHeap.Count, "Count before");
            Assert.AreEqual(9, _binaryMaxHeap.PeekMax(), "Max before");
            
            _binaryMaxHeap.RemoveMax();
            
            Assert.AreEqual(1, _binaryMaxHeap.Count, "Count After");
            Assert.AreEqual(5, _binaryMaxHeap.PeekMax(), "Max After");
        }

        [Test]
        public void PopMax_Empty()
        {
            Assert.Throws<InvalidOperationException>(delegate
            {
                _binaryMaxHeap.PopMax();
            });
        }

        [Test]
        public void PopMax_Available()
        {
            _binaryMaxHeap.Add(5);
            _binaryMaxHeap.Add(9);
            
            Assert.AreEqual(9, _binaryMaxHeap.PeekMax(), "Max before");
            Assert.AreEqual(2, _binaryMaxHeap.Count, "Count before");
            
            Assert.AreEqual(9, _binaryMaxHeap.PopMax(), "Returned max");
            
            Assert.AreEqual(1, _binaryMaxHeap.Count, "Count before");
            Assert.AreEqual(5, _binaryMaxHeap.PeekMax(), "Max After");
        }

        [Test]
        public void Clear()
        {
            _binaryMaxHeap.Add(5);
            _binaryMaxHeap.Add(4);
            _binaryMaxHeap.Add(9);
            _binaryMaxHeap.Add(13);
            
            Assert.NotZero(_binaryMaxHeap.Count);
            
            _binaryMaxHeap.Clear();
            
            Assert.Zero(_binaryMaxHeap.Count);
        }

        [Test]
        public void Heapify_Null()
        {
            Assert.Throws<ArgumentNullException>(delegate
            { 
                List<int> list = null;
                _binaryMaxHeap.Heapify(list);
            });
        }

        [Test]
        public void Heapify_Empty()
        {
            var list = new List<int>();
            _binaryMaxHeap.Heapify(list);
            
            Assert.Zero(_binaryMaxHeap.Count, "Count");
            Assert.Throws<InvalidOperationException>(delegate
            {
                _binaryMaxHeap.PeekMax();
            }, "Max");
        }

        [Test]
        public void Heapify_NotEmpty()
        {
            Assert.Zero(_binaryMaxHeap.Count, "Count before");
            Assert.Throws<InvalidOperationException>(delegate
            {
                _binaryMaxHeap.PeekMax();
            }, "Max before");
            
            var list = new List<int>() { -1, 8, 5, 21, 4 };
            _binaryMaxHeap.Heapify(list);
            
            Assert.AreEqual(5, _binaryMaxHeap.Count, "Count after");
            Assert.AreEqual(21, _binaryMaxHeap.PeekMax(), "Max after");
        }

        [Test]
        public void ToArray_Empty()
        {
            Assert.IsEmpty(_binaryMaxHeap.ToArray());
        }

        [Test]
        public void ToArray_NotEmpty()
        {
            _binaryMaxHeap.Add(2);
            _binaryMaxHeap.Add(6);
            _binaryMaxHeap.Add(5);
            
            Assert.IsNotEmpty(_binaryMaxHeap.ToArray());
        }

        [Test]
        public void BinaryMaxHeap_DescendingOrder()
        {
            var before = new List<int>() { 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            _binaryMaxHeap.Heapify(before);

            var after = new List<int>();
            while (!_binaryMaxHeap.IsEmpty)
            {
                after.Add(_binaryMaxHeap.PopMax());
            }

            Assert.AreEqual(before, after);
        }

        [Test]
        public void BinaryMaxHeap_NoOrder()
        {
            var before = new List<int>() { 65, 5, 12, 8, 9, 0, -23 };
            _binaryMaxHeap.Heapify(before);

            before.Sort();
            before.Reverse();
            var after = new List<int>();
            while (!_binaryMaxHeap.IsEmpty)
            {
                after.Add(_binaryMaxHeap.PopMax());
            }

            Assert.AreEqual(before, after);
        }

        [Test]
        public void Merge_Null()
        {
            BinaryMaxHeap<int> otherBinaryMaxHeap = null;

            Assert.Throws<ArgumentNullException>(delegate
            {
                _binaryMaxHeap.Merge(otherBinaryMaxHeap);
            });
        }

        [Test]
        public void Merge_Empty()
        {
            var list = new List<int>() {1, 5, 0, -2, 4};
            _binaryMaxHeap.Heapify(list);
            BinaryMaxHeap<int> otherBinaryMaxHeap = new BinaryMaxHeap<int>();

            int countBefore = _binaryMaxHeap.Count;
            
            _binaryMaxHeap.Merge(otherBinaryMaxHeap);
            
            Assert.AreEqual(countBefore, _binaryMaxHeap.Count, "Count didn't change");
        }

        [Test]
        public void Merge_NotEmpty()
        {
            var list = new List<int>() {1, 5, 0, -2, 4};
            _binaryMaxHeap.Heapify(list);
            BinaryMaxHeap<int> otherBinaryMaxHeap = new BinaryMaxHeap<int>();
            list = new List<int>() {4, 32, -5};
            otherBinaryMaxHeap.Heapify(list);

            int countBefore = _binaryMaxHeap.Count;
            
            _binaryMaxHeap.Merge(otherBinaryMaxHeap);
            
            Assert.Greater(_binaryMaxHeap.Count, countBefore, "Count changed");
        }
    }
}
