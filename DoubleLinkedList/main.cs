using System;

namespace DoubleLinkedList
{
    internal class main
    {
        static void Main(string[] args)
        {
            DoubleLinkedList list = new DoubleLinkedList();

            list.AddFirst(1);
            list.AddFirst(2);
            list.AddLast(4);
            list.AddLast(2);
            list.AddAtPos(8, 2);

            Console.WriteLine("list traverse ");
            list.Traverse();

            list.RemoveAtBegin();
            list.RemoveAtEnd();
            list.RemoveAtPos(2);

            Console.WriteLine("list aftert remove");    // 1
            list.Traverse();
        }
    }
}
