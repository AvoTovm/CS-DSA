using System;


namespace HeapTree
{
    internal class main
    {
        static void Main(string[] args)
        {
            HeapTree heap = new HeapTree();

            heap.Insert(10);
            heap.Insert(20);
            heap.Insert(5);
            heap.Insert(30);

            heap.PrintHeap();

            heap.ExtractValue(30);
            heap.PrintHeap();
        }
    }
}
