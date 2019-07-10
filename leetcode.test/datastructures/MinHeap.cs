using System.Collections.Generic;
using NUnit.Framework;
using leetcode.datastructures;

namespace leetcode.test.datastructures
{
    public class MinHeap
    {
        [Test]
        public void TestSingleItem()
        {
            var heap = new MinHeap<int>((i1, i2) => i1 - i2);

            heap.Push(1);

            Assert.AreEqual(1, heap.Count);
            Assert.AreEqual(1, heap.Peek());

            Assert.AreEqual(1, heap.Pop());
            Assert.AreEqual(0, heap.Count);
        }

        [Test]
        public void TestTwoItemsInSortedOrder()
        {
            var heap = new MinHeap<int>((i1, i2) => i1 - i2);

            heap.Push(1);

            Assert.AreEqual(1, heap.Count);
            Assert.AreEqual(1, heap.Peek());

            heap.Push(2);

            Assert.AreEqual(2, heap.Count);
            Assert.AreEqual(1, heap.Peek());

            Assert.AreEqual(1, heap.Pop());
            Assert.AreEqual(1, heap.Count);

            Assert.AreEqual(2, heap.Pop());
            Assert.AreEqual(0, heap.Count);
        }

        [Test]
        public void TestTwoItemsInReverseOrder()
        {
            var heap = new MinHeap<int>((i1, i2) => i1 - i2);

            heap.Push(2);

            Assert.AreEqual(1, heap.Count);
            Assert.AreEqual(2, heap.Peek());

            heap.Push(1);

            Assert.AreEqual(2, heap.Count);
            Assert.AreEqual(1, heap.Peek());

            Assert.AreEqual(1, heap.Pop());
            Assert.AreEqual(1, heap.Count);

            Assert.AreEqual(2, heap.Pop());
            Assert.AreEqual(0, heap.Count);
        }

        [Test]
        public void TestThreeItemsInSortedOrder()
        {
            var heap = new MinHeap<int>((i1, i2) => i1 - i2);

            heap.Push(1);

            Assert.AreEqual(1, heap.Count);
            Assert.AreEqual(1, heap.Peek());

            heap.Push(2);

            Assert.AreEqual(2, heap.Count);
            Assert.AreEqual(1, heap.Peek());

            heap.Push(3);

            Assert.AreEqual(3, heap.Count);
            Assert.AreEqual(1, heap.Peek());

            Assert.AreEqual(1, heap.Pop());
            Assert.AreEqual(2, heap.Count);

            Assert.AreEqual(2, heap.Pop());
            Assert.AreEqual(1, heap.Count);

            Assert.AreEqual(3, heap.Pop());
            Assert.AreEqual(0, heap.Count);
        }

        [Test]
        public void TestThreeItemsInReverseOrder()
        {
            var heap = new MinHeap<int>((i1, i2) => i1 - i2);

            heap.Push(3);

            Assert.AreEqual(1, heap.Count);
            Assert.AreEqual(3, heap.Peek());

            heap.Push(2);

            Assert.AreEqual(2, heap.Count);
            Assert.AreEqual(2, heap.Peek());

            heap.Push(1);

            Assert.AreEqual(3, heap.Count);
            Assert.AreEqual(1, heap.Peek());

            Assert.AreEqual(1, heap.Pop());
            Assert.AreEqual(2, heap.Count);

            Assert.AreEqual(2, heap.Pop());
            Assert.AreEqual(1, heap.Count);

            Assert.AreEqual(3, heap.Pop());
            Assert.AreEqual(0, heap.Count);
        }

        [Test]
        public void TestThreeItemsInRandomOrder()
        {
            var heap = new MinHeap<int>((i1, i2) => i1 - i2);

            heap.Push(2);

            Assert.AreEqual(1, heap.Count);
            Assert.AreEqual(2, heap.Peek());

            heap.Push(3);

            Assert.AreEqual(2, heap.Count);
            Assert.AreEqual(2, heap.Peek());

            heap.Push(1);

            Assert.AreEqual(3, heap.Count);
            Assert.AreEqual(1, heap.Peek());

            Assert.AreEqual(1, heap.Pop());
            Assert.AreEqual(2, heap.Count);

            Assert.AreEqual(2, heap.Pop());
            Assert.AreEqual(1, heap.Count);

            Assert.AreEqual(3, heap.Pop());
            Assert.AreEqual(0, heap.Count);
        }

        [Test]
        public void TestFourItemsInRandomOrder()
        {
            var heap = new MinHeap<int>((i1, i2) => i1 - i2);

            heap.Push(2);

            Assert.AreEqual(1, heap.Count);
            Assert.AreEqual(2, heap.Peek());

            heap.Push(3);

            Assert.AreEqual(2, heap.Count);
            Assert.AreEqual(2, heap.Peek());

            heap.Push(1);

            Assert.AreEqual(3, heap.Count);
            Assert.AreEqual(1, heap.Peek());

            heap.Push(4);

            Assert.AreEqual(4, heap.Count);
            Assert.AreEqual(1, heap.Peek());

            Assert.AreEqual(1, heap.Pop());
            Assert.AreEqual(3, heap.Count);

            Assert.AreEqual(2, heap.Pop());
            Assert.AreEqual(2, heap.Count);

            Assert.AreEqual(3, heap.Pop());
            Assert.AreEqual(1, heap.Count);

            Assert.AreEqual(4, heap.Pop());
            Assert.AreEqual(0, heap.Count);
        }

        [Test]
        public void TestHeapifyEmpty()
        {
            var heap = new MinHeap<int>(new List<int> { }, (i1, i2) => i1 - i2);

            Assert.AreEqual(0, heap.Count);
        }

        [Test]
        public void TestHeapifySingleItem()
        {
            var heap = new MinHeap<int>(new List<int> { 1 }, (i1, i2) => i1 - i2);

            Assert.AreEqual(1, heap.Count);
            Assert.AreEqual(1, heap.Peek());
        }

        [Test]
        public void TestHeapifyPreSorted()
        {
            var heap = new MinHeap<int>(new List<int> { 1, 2, 3, 4 }, (i1, i2) => i1 - i2);

            Assert.AreEqual(4, heap.Count);
            Assert.AreEqual(1, heap.Peek());

            Assert.AreEqual(1, heap.Pop());
            Assert.AreEqual(3, heap.Count);

            Assert.AreEqual(2, heap.Pop());
            Assert.AreEqual(2, heap.Count);

            Assert.AreEqual(3, heap.Pop());
            Assert.AreEqual(1, heap.Count);

            Assert.AreEqual(4, heap.Pop());
            Assert.AreEqual(0, heap.Count);
        }

        [Test]
        public void TestHeapifyReverseSorted()
        {
            var heap = new MinHeap<int>(new List<int> { 4, 3, 2, 1 }, (i1, i2) => i1 - i2);

            Assert.AreEqual(4, heap.Count);
            Assert.AreEqual(1, heap.Peek());

            Assert.AreEqual(1, heap.Pop());
            Assert.AreEqual(3, heap.Count);

            Assert.AreEqual(2, heap.Pop());
            Assert.AreEqual(2, heap.Count);

            Assert.AreEqual(3, heap.Pop());
            Assert.AreEqual(1, heap.Count);

            Assert.AreEqual(4, heap.Pop());
            Assert.AreEqual(0, heap.Count);
        }

        [Test]
        public void TestHeapifyRandomOrder()
        {
            var heap = new MinHeap<int>(new List<int> { 3, 4, 1, 2 }, (i1, i2) => i1 - i2);

            Assert.AreEqual(4, heap.Count);
            Assert.AreEqual(1, heap.Peek());

            Assert.AreEqual(1, heap.Pop());
            Assert.AreEqual(3, heap.Count);

            Assert.AreEqual(2, heap.Pop());
            Assert.AreEqual(2, heap.Count);

            Assert.AreEqual(3, heap.Pop());
            Assert.AreEqual(1, heap.Count);

            Assert.AreEqual(4, heap.Pop());
            Assert.AreEqual(0, heap.Count);
        }

        [Test]
        public void TestHeapifyAndPush()
        {
            var heap = new MinHeap<int>(new List<int> { 3, 1, 2, }, (i1, i2) => i1 - i2);

            Assert.AreEqual(1, heap.Pop());
            Assert.AreEqual(2, heap.Count);

            Assert.AreEqual(2, heap.Peek());

            TestContext.Out.Write(string.Join(", ", heap._items));

            heap.Push(4);

            TestContext.Out.Write(string.Join(", ", heap._items));

            Assert.AreEqual(2, heap.Peek());
            Assert.AreEqual(3, heap.Count);

            Assert.AreEqual(2, heap.Pop());
            Assert.AreEqual(2, heap.Count);

            heap.Push(1);

            Assert.AreEqual(1, heap.Peek());
            Assert.AreEqual(3, heap.Count);

            Assert.AreEqual(1, heap.Pop());
            Assert.AreEqual(2, heap.Count);

            Assert.AreEqual(3, heap.Pop());
            Assert.AreEqual(1, heap.Count);

            Assert.AreEqual(4, heap.Pop());
            Assert.AreEqual(0, heap.Count);
        }
    }
}