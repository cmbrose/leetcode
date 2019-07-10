using System;
using System.Collections.Generic;

namespace leetcode.datastructures
{
    public class MinHeap<T>
    {
        public List<T> _items;
        private Func<T, T, int> _compare;

        public int Count { get; private set; }

        public MinHeap(List<T> items, Func<T, T, int> compare)
        {
            _items = items;
            _compare = compare;

            Count = _items.Count;

            for (int i = Count / 2; i > -1; --i)
            {
                Heapify(i);
            }
        }

        public MinHeap(Func<T, T, int> compare)
        {
            _items = new List<T>();
            _compare = compare;

            Count = 0;
        }

        private void Heapify(int root)
        {
            int smallerIdx = root;
            int leftIdx = LeftChildOf(root);
            int rightIdx = RightChildOf(root);

            if (leftIdx < Count && _compare(_items[smallerIdx], _items[leftIdx]) > 0)
            {
                smallerIdx = leftIdx;
            }

            if (rightIdx < Count && _compare(_items[smallerIdx], _items[rightIdx]) > 0)
            {
                smallerIdx = rightIdx;
            }

            if (smallerIdx != root)
            {
                Swap(root, smallerIdx);
                Heapify(smallerIdx);
            }
        }

        public void Push(T item)
        {
            if (_items.Count == Count)
            {
                _items.Add(item);
            }
            else
            {
                _items[Count] = item;
            }
            
            ++Count;

            PercolateUp(Count - 1);
        }

        public T Peek()
        {
            return _items[0];
        }

        public T Pop()
        {
            T root = Peek();

            Swap(0, Count - 1);
            --Count;

            PercolateDown(0);

            return root;
        }

        private void PercolateUp(int idx)
        {
            int parIdx = ParentOf(idx);

            if (parIdx < 0)
            {
                return;
            }

            T cur = _items[idx];
            T par = _items[parIdx];

            int comp = _compare(cur, par);

            if (comp < 0)
            {
                Swap(idx, parIdx);
                PercolateUp(parIdx);
            }
        }

        private void PercolateDown(int idx)
        {
            int leftIdx = LeftChildOf(idx);
            int rightIdx = RightChildOf(idx);

            if (Count <= leftIdx)
            {
                return;
            }

            T cur = _items[idx];
            T left = _items[leftIdx];

            int targetIdx;
            T targetItem;

            if (Count > rightIdx)
            {
                T right = _items[rightIdx];

                int childComp = _compare(left, right);

                if (childComp < 0)
                {
                    targetIdx = leftIdx;
                    targetItem = left;
                }
                else
                {
                    targetIdx = rightIdx;
                    targetItem = right;
                }
            }
            else
            {
                targetIdx = leftIdx;
                targetItem = left;
            }

            int comp = _compare(cur, targetItem);

            if (comp > 0)
            {
                Swap(idx, targetIdx);
                PercolateDown(targetIdx);
            }
        }

        private void Swap(int idx1, int idx2)
        {
            T tmp = _items[idx1];
            _items[idx1] = _items[idx2];
            _items[idx2] = tmp;
        }

        private static int ParentOf(int idx)
        {
            if (idx == 0)
            {
                return -1;
            }

            return (idx - 1) / 2;
        }

        private static int LeftChildOf(int idx)
        {
            return idx * 2 + 1;
        }

        private static int RightChildOf(int idx)
        {
            return LeftChildOf(idx) + 1;
        }
    }
}