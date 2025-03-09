using System;
using System.Collections.Generic;
using System.Linq;

namespace HeapTree
{
    public class HeapTree
    {
        private List<int> heap;

        public HeapTree()
        {
            heap = new List<int>();
        }

        public void PrintHeap()
        {
            for(int i = 0; i < heap.Count; i++)
            {
                Console.Write(heap[i] + " ");
            }
            Console.WriteLine();
        }

        public void Insert(int key)
        {
            heap.Add(key);
            int index = heap.Count - 1;

            while(index > 0 && heap[(index - 1) / 2] < heap[index])
            {
                (heap[(index - 1) / 2], heap[index]) = (heap[index], heap[(index - 1) / 2]);
                index = (index - 1) / 2;
            }

        }

        public void ExtractValue(int key)
        {
            int size = heap.Count;
            if (size == 0) throw new Exception("heap is empty");

            int index = -1;
            for(int i = 0; i < size; i++)
            {
                if(heap[i] == key)
                {
                    index = i;
                    break;
                }
            }

            if (index == -1) throw new Exception("Value not found");
            heap[index] = heap.Last();
            heap.RemoveAt(heap.Count - 1);

            int largest = index;
            int left = 2 * index + 1;
            int right = 2 * index + 2;
            size = heap.Count;

            while (true)
            {
                if(left < size && heap[left] > heap[largest])
                {
                    largest = left;
                }if(right < size && heap[right] > heap[largest])
                {
                    largest = right;
                }

                if(largest != index)
                {
                    (heap[index], heap[largest]) = (heap[largest], heap[index]);
                    index = largest;
                    left = 2 * index + 1;
                    right = 2 * index + 2;
                }
                else
                {
                    break;
                }
            }
        }
    }
}
