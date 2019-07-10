using System.Linq;
using System.Collections.Generic;
using leetcode.datastructures;

namespace leetcode
{
    public static class Question1090
    {
        // Single heap
        public static int Solve(int[] values, int[] labels, int num_wanted, int use_limit) 
        {
            var heap = new MinHeap<Node>((n1, n2) => n2.Value - n1.Value);

            var usageRefs = new Dictionary<int, UsageRef>();

            for (int i = 0; i < values.Length; ++i)
            {
                var value = values[i];
                var label = labels[i];

                if (!usageRefs.TryGetValue(label, out var usageRef))
                {
                    usageRef = new UsageRef { Value = 0 };
                    usageRefs[label] = usageRef;
                }

                heap.Push(new Node { Value = value, Usage = usageRef });
            }

            int sum = 0;
            while (num_wanted > 0 && heap.Count > 0)
            {
                var next = heap.Pop();

                if (next.Usage.Value < use_limit)
                {
                    sum += next.Value;
                    next.Usage.Value += 1;

                    --num_wanted;
                }
            }

            return sum;
        }

        private class Node
        {
            public int Value { get; set; }

            public UsageRef Usage {get;set;}
        }

        private class UsageRef
        {
            public int Value;
        }

        // Heap of Heaps
        // public static int Solve(int[] values, int[] labels, int num_wanted, int use_limit) 
        // {
        //     var heapMap = new Dictionary<int, MinHeap<int>>();

        //     for (int i = 0; i < values.Length; ++i)
        //     {
        //         var value = values[i];
        //         var label = labels[i];

        //         if (!heapMap.TryGetValue(label, out MinHeap<int> heap))
        //         {
        //             heap = new MinHeap<int>((i1, i2) => i2 - i1);
        //             heapMap[label] = heap;
        //         }

        //         heap.Push(value);
        //     }

        //     var heapHeap = new MinHeap<CountedHeap>((h1, h2) => h2.Heap.Peek() - h1.Heap.Peek());

        //     //foreach (var kvp in heapMap)
        //     foreach (var heap in heapMap.Values)
        //     {
        //         //heapHeap.Push(new CountedHeap { Heap = kvp.Value, UsageCount = 0, Label = kvp.Key });
        //         heapHeap.Push(new CountedHeap { Heap = heap, UsageCount = 0, Label = -1 });
        //     }

        //     int sum = 0;
        //     while (num_wanted > 0 && heapHeap.Count > 0)
        //     {
        //         var bestHeap = heapHeap.Pop();
        //         int val = bestHeap.Heap.Pop();
            
        //         sum += val;

        //         ++bestHeap.UsageCount;

        //         if (bestHeap.UsageCount < use_limit && bestHeap.Heap.Count > 0)
        //         {
        //             heapHeap.Push(bestHeap);
        //         }

        //         --num_wanted;
        //     }

        //     return sum;
        // }

        // private class CountedHeap
        // {
        //     public MinHeap<int> Heap { get; set; }

        //     public int Label {get;set;}

        //     public int UsageCount { get; set; }
        // }
    }
}